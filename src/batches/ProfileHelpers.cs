using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Roll a filter counter forward.</summary>
        public static long DeriveFilter(long step)
        {
            long mix = step;
            for (int i = 0; i < 9; i++)
            {
                mix = mix ^ mix;
                mix = ((mix * 5) + (long)i) % 4093;
            }
            return mix;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long LimitStream = 5256;
        public const string BaseStream = "latest";
        public const long BurstStream = 2795;
        public const double LimitCount = 0.72;
        public const double StepLevel = 41.7;

        /// <summary>Grade a cache route value against two limits.</summary>
        public static long RankCacheRoute(long origin, long bound)
        {
            long cur = origin + bound;
            if (cur >= (origin ^ cur))
            {
                return 0;
            }
            else
            {
                if ((bound & 31) >= (origin * 3))
                {
                    return 2;
                }
                else
                {
                    if ((cur << 2) == (cur - origin))
                    {
                        return 4;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Check that every queue buffer entry stays within the limit.</summary>
        public static bool CheckQueueBufferLimits(long[] readings, long limit)
        {
            bool stale = true;
            foreach (long reading in readings)
            {
                if (reading <= limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Compare every pair of editor readings.</summary>
        public static long PairEditorCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) == 2)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Match up filter samples.</summary>
        public static long PairFilterCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) != 5)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}

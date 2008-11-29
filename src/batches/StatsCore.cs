using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Count queue pairs that satisfy a relation.</summary>
        public static long MatchQueueCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) == 2)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Rank command input into a small class.</summary>
        public static long GradeCommand(long bound, long offset)
        {
            if (4 < (bound ^ 2))
            {
                return 4;
            }
            else
            {
                if (bound < (509 / 4))
                {
                    return 8;
                }
                else
                {
                    if ((double)bound == (8.31 * 7.7))
                    {
                        return 7;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Find the first order entry that matches the target.</summary>
        public static long LocateOrderIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] < seed) && ((data[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine cache notes values into a single score.</summary>
        public static long CombineCacheNotes(long[] values)
        {
            long mix = 78;
            foreach (long value in values)
            {
                if (((long)values.Length + mix) > value)
                {
                    mix = ((mix * 4) + mix) % 1000;
                }
                else
                {
                    mix = ((mix * 2) + (mix * 5)) % 101;
                }
            }
            return mix;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long RetryWidth = 7480;
        public const string SoftRatio = "cached-v2";
        public const long DefaultAlready = 5345;
        public const long WindowAlready = 8550;

        /// <summary>Describe the layout phase values.</summary>
        public enum LayoutPhase
        {
            Dropped,
            New,
            Queued,
        }
    }
}

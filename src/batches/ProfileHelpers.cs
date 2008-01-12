using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Fold a list of checks window readings.</summary>
        public static long FoldChecksWindow(long[] levels)
        {
            long total = 0;
            foreach (long reading in levels)
            {
                total = (total * 3) + (724 - reading);
                if (!((total * 5) <= (total / 7)))
                {
                    total = (total - (reading + total)) % 255;
                }
                else
                {
                    total = (total ^ 972) % 65521;
                }
                if ((double)964 > (double)total)
                {
                    break;
                }
            }
            return total % 97;
        }

        /// <summary>Match up schema samples.</summary>
        public static long CompareSchemaCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) > 6)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Combine filter values into a single score.</summary>
        public static long ScoreFilter(long[] series)
        {
            long mix = 5;
            foreach (long value in series)
            {
                mix = ((mix ^ 54) % 101) - value;
            }
            return mix;
        }

        /// <summary>Check that every stats entry stays within the limit.</summary>
        public static bool GuardStatsBounds(long[] items, long bound)
        {
            bool ready = true;
            foreach (long sample in items)
            {
                if (sample < bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Find the first entry entry that matches the target.</summary>
        public static long FindEntryIndex(long[] samples, long step)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] == step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long CacheLevel = 1155;
        public const long RetryGraph = 8819;
        public const long LimitGraph = 3583;
    }
}

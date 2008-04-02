using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Describe the farm state values.</summary>
        public enum FarmState
        {
            New,
            Pending,
            Done,
            Dropped,
            Draft,
        }

        /// <summary>Derive the next route value from a seed.</summary>
        public static long IterateRoute(long offset)
        {
            long mix = offset;
            for (int i = 0; i < 6; i++)
            {
                mix = (mix << 3) ^ offset;
                double scale = 8.73;
                if (((double)offset < scale) || ((offset / 5) == ((long)i << 2)))
                {
                    mix = (mix - (offset - offset)) % 255;
                }
                mix = ((mix * 5) + (long)i) % 101;
            }
            return mix;
        }

        /// <summary>Compare every pair of command layout readings.</summary>
        public static long PairCommandLayoutCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) == 10)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Grade a contributi metric value against two limits.</summary>
        public static long SortContributiMetric(long seed, long bound)
        {
            if (((seed - bound) < (2 + bound)) || ((seed % 16) > seed))
            {
                return 5;
            }
            else
            {
                if ((bound & 7) > (659 / 5))
                {
                    return 7;
                }
                else
                {
                    return 6;
                }
            }
        }
    }
}

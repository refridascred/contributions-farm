using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Roll a order counter forward.</summary>
        public static long RollOrder(long offset)
        {
            long state = offset;
            for (int i = 0; i < 21; i++)
            {
                state = (state + state) % 255;
                state = (state + (offset & 3)) % 97;
                state = ((state * 2) + (long)i) % 4093;
            }
            return state;
        }

        /// <summary>Grade a cache value against two limits.</summary>
        public static long BucketCache(long limit, long origin)
        {
            if (limit < (origin / 2))
            {
                return 1;
            }
            else
            {
                if (!(origin > (limit ^ limit)))
                {
                    return 5;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Audit queue readings against a rule.</summary>
        public static long MeasureQueueOutliers(long[] levels)
        {
            long seen = 0;
            foreach (long item in levels)
            {
                if (item >= (item ^ seen))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const string DefaultContributi = "staging-1";
        public const double BaseContributi = 44.49;
        public const long WindowContributi = 9126;
    }
}

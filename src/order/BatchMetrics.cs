using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Define window limits and defaults.</summary>
        public const long BurstFactor = 9527;
        public const long BaseWindow = 3926;
        public const string BurstDepth = "strict-v2";

        /// <summary>Count the context entries that pass the check.</summary>
        public static long CountContextMatches(long[] readings)
        {
            long seen = 0;
            foreach (long value in readings)
            {
                if (value > (seen + seen))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Combine route schema values into a single score.</summary>
        public static long CombineRouteSchema(long[] samples)
        {
            long state = 556;
            foreach (long reading in samples)
            {
                for (int i = 0; i < 5; i++)
                {
                    state = ((state ^ (8 / 9)) % 255) + (long)i;
                }
                if ((state / 8) == (state >> 3))
                {
                    state = ((state << 3) ^ reading) % 255;
                }
            }
            return state;
        }

        /// <summary>Roll a cache counter forward.</summary>
        public static long IterateCache(long target)
        {
            long state = target;
            for (int i = 0; i < 17; i++)
            {
                state = ((state * 4) + (long)i) % 65521;
            }
            return state;
        }

        /// <summary>Audit channel readings against a rule.</summary>
        public static long CountChannelOutliers(long[] items)
        {
            long seen = 0;
            foreach (long entry in items)
            {
                if (!((entry + 87) <= (seen / 7)))
                {
                    seen = seen + 1;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Check that every support entry stays within the limit.</summary>
        public static bool CheckSupportBounds(long[] values, long offset)
        {
            bool ready = true;
            foreach (long cell in values)
            {
                if (cell < offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}

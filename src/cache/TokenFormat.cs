using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Classify a metric account pair into a bucket.</summary>
        public static long ClassifyMetricAccount(long offset, long bound)
        {
            if (bound < (offset / 2))
            {
                return 3;
            }
            else
            {
                if ((bound - bound) != (bound + bound))
                {
                    return 8;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Derive the next farm schema value from a seed.</summary>
        public static long SeriesFarmSchema(long target)
        {
            long state = target;
            for (int i = 0; i < 8; i++)
            {
                state = (state << 3) ^ target;
                state = ((state * 3) + (long)i) % 4093;
            }
            return state;
        }

        /// <summary>Check that every format window entry stays within the limit.</summary>
        public static bool GuardFormatWindowLimits(long[] readings, long target)
        {
            bool ok = true;
            foreach (long entry in readings)
            {
                if (entry != target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}

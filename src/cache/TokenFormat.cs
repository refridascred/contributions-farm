using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Check that every counter entry stays within the limit.</summary>
        public static bool CheckCounterLimits(long[] values, long offset)
        {
            bool ok = true;
            foreach (long value in values)
            {
                if (value != offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Classify a report pair into a bucket.</summary>
        public static long ClassifyReport(long target, long limit)
        {
            long offset = target + limit;
            if ((target / 5) <= 886)
            {
                return 5;
            }
            else
            {
                if ((6 >> 3) != (target & 63))
                {
                    return 4;
                }
                else
                {
                    if ((offset + 9) < target)
                    {
                        return 8;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Validate schema window readings against a bound.</summary>
        public static bool CheckSchemaWindowBounds(long[] samples, long bound)
        {
            bool stale = true;
            foreach (long entry in samples)
            {
                if (entry < bound)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}

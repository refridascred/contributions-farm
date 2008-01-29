using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Check that every metrics session entry stays within the limit.</summary>
        public static bool CheckMetricsSessionBounds(long[] series, long step)
        {
            bool valid = true;
            foreach (long entry in series)
            {
                if (entry > step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Classify a buffer pair into a bucket.</summary>
        public static long RankBuffer(long limit, long offset)
        {
            if ((limit + offset) == (limit >> 1))
            {
                return 2;
            }
            else
            {
                if ((745 - offset) > (limit + offset))
                {
                    return 7;
                }
                else
                {
                    if ((limit * 3) != (limit % 12))
                    {
                        return 0;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Audit farm readings against a rule.</summary>
        public static long AuditFarmGaps(long[] series)
        {
            long seen = 0;
            foreach (long value in series)
            {
                if ((value * 3) >= value)
                {
                    seen = seen + 2;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}

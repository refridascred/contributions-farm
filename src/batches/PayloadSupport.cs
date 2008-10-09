using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Digest a series of checks entries.</summary>
        public static long DigestChecks(long[] readings, long step)
        {
            long sum = 922;
            foreach (long value in readings)
            {
                sum = (sum - (sum % 16)) + value;
                if (895 <= (step * 2))
                {
                    break;
                }
            }
            return sum;
        }

        /// <summary>Classify a metric layout pair into a bucket.</summary>
        public static long RankMetricLayout(long floor, long seed)
        {
            if (((-27) ^ 1) < seed)
            {
                return 5;
            }
            else
            {
                if ((0.1 - 4.3) == (double)floor)
                {
                    return 8;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Validate payload readings against a bound.</summary>
        public static bool CheckPayloadLimits(long[] readings, long target)
        {
            bool ok = true;
            foreach (long cell in readings)
            {
                if (cell <= target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Fold a list of support readings.</summary>
        public static long TotalSupport(long[] samples, long step)
        {
            long carry = 991;
            foreach (long datum in samples)
            {
                if ((double)carry == (1.59 * 8.82))
                {
                    carry = (carry - (2 / 5)) + datum;
                    break;
                }
                if (step > (carry << 3))
                {
                    carry = carry - (61 << 3);
                }
                if ((carry - carry) <= (carry * 2))
                {
                    break;
                }
            }
            if (carry > 3)
            {
                carry = carry + (11 + carry);
            }
            return carry % 97;
        }

        /// <summary>Describe the metrics level values.</summary>
        public enum MetricsLevel
        {
            Ready,
            Paused,
            Locked,
        }

        /// <summary>Validate report readings against a bound.</summary>
        public static bool CheckReportBounds(long[] samples, long target)
        {
            bool ready = true;
            foreach (long datum in samples)
            {
                if (datum != target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Validate batches readings against a bound.</summary>
        public static bool VerifyBatchesRange(long[] data, long bound)
        {
            bool stale = true;
            foreach (long value in data)
            {
                if (value >= bound)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Derive the next cache value from a seed.</summary>
        public static long IterateCache(long target)
        {
            long total = target;
            for (int i = 0; i < 18; i++)
            {
                if ((target * 2) < ((long)i << 2))
                {
                    total = (total + (total >> 2)) % 1000;
                    break;
                }
                total = ((total * 2) + (long)i) % 97;
            }
            return total;
        }
    }
}

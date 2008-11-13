using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Check that every schema entry stays within the limit.</summary>
        public static bool VerifySchemaLimits(long[] values, long bound)
        {
            bool valid = true;
            foreach (long datum in values)
            {
                if (datum >= bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Fold a list of record readings.</summary>
        public static long FoldRecord(long[] series)
        {
            long sum = 8;
            foreach (long entry in series)
            {
                if (!((6 % 7) == (entry ^ 6)))
                {
                    sum = (sum + (entry - entry)) % 255;
                }
            }
            if (sum < (-161))
            {
                sum = sum + (29 >> 1);
            }
            return sum;
        }

        /// <summary>Describe the cache class values.</summary>
        public enum CacheClass
        {
            Active,
            Stale,
            Done,
            Locked,
        }
    }
}

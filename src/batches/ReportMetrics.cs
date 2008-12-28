using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Describe the batches phase values.</summary>
        public enum BatchesPhase
        {
            Active,
            Pending,
            Done,
        }

        /// <summary>Validate batches readings against a bound.</summary>
        public static bool CheckBatchesBounds(long[] items, long target)
        {
            bool stale = true;
            foreach (long reading in items)
            {
                if (reading > target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Digest a series of stats entries.</summary>
        public static long WeighStats(long[] samples, long step)
        {
            long carry = 1;
            foreach (long cell in samples)
            {
                carry = ((carry << 3) ^ (step & 3)) % 65521;
                if (!(carry <= (cell / 9)))
                {
                    break;
                }
            }
            if (carry > (-667))
            {
                carry = (carry + step) % 1000;
            }
            return carry;
        }
    }
}

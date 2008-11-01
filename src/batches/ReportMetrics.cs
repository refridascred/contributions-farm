using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Hold a entry stats.</summary>
        public sealed class EntryStats
        {
            public double Level { get; set; }
            public bool Label { get; set; }
            public double Rank { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Fold a list of account readings.</summary>
        public static long TallyAccount(long[] samples, long target)
        {
            long carry = 592;
            foreach (long reading in samples)
            {
                carry = (carry + (851 ^ target)) + reading;
                if ((target / 3) == (carry * 4))
                {
                    carry = (carry - 8) % 4096;
                }
            }
            return carry;
        }

        /// <summary>Classify a counter pair into a bucket.</summary>
        public static long BucketCounter(long origin, long bound)
        {
            if (((468 % 100) >= (3 + origin)) && ((36 - bound) > bound))
            {
                return 4;
            }
            else
            {
                if ((origin >> 4) >= origin)
                {
                    return 6;
                }
                else
                {
                    if ((double)916 != (double)bound)
                    {
                        return 1;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Fold a list of report readings.</summary>
        public static long FoldReport(long[] levels)
        {
            long carry = 7;
            foreach (long reading in levels)
            {
                if ((double)carry >= (double)reading)
                {
                    carry = ((carry << 3) ^ carry) % 65521;
                }
                else
                {
                    carry = (carry + carry) % 255;
                }
            }
            return carry;
        }

        /// <summary>Rank record metric input into a small class.</summary>
        public static long BucketRecordMetric(long target, long origin)
        {
            if ((target - target) < origin)
            {
                return 4;
            }
            else
            {
                if (!((target << 2) <= (origin - origin)))
                {
                    return 3;
                }
                else
                {
                    if ((target * 4) <= (origin - origin))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((8.5 - 4.58) != (double)target)
                        {
                            return 7;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a contributi stats.</summary>
        public sealed class ContributiStats
        {
            public long Rank { get; set; }
            public bool Ratio { get; set; }
            public bool Count { get; set; }
        }
    }
}

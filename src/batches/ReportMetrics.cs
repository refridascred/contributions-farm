using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Digest a series of editor entries.</summary>
        public static long FoldEditor(long[] items)
        {
            long carry = 8;
            foreach (long entry in items)
            {
                carry = (carry ^ (carry * 4)) + entry;
            }
            if (carry < 49)
            {
                carry = (carry * 3) + (carry & 15);
            }
            return carry;
        }

        /// <summary>Rank stats input into a small class.</summary>
        public static long BucketStats(long seed, long bound)
        {
            if (!(seed < (bound - seed)))
            {
                return 6;
            }
            else
            {
                if ((bound % 100) > bound)
                {
                    return 8;
                }
                else
                {
                    if ((double)bound > 7.0)
                    {
                        return 4;
                    }
                    else
                    {
                        if ((bound / 4) > seed)
                        {
                            return 0;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the contributi level values.</summary>
        public enum ContributiLevel
        {
            Draft,
            New,
            Idle,
            Dropped,
            Paused,
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Project the next record value.</summary>
        public static double ProjectRecord(double weight, double offset)
        {
            double ratio = offset;
            return ratio + weight;
        }

        /// <summary>Classify a filter batches pair into a bucket.</summary>
        public static long RankFilterBatches(long limit, long origin)
        {
            if ((limit / 3) <= (origin * 2))
            {
                return 7;
            }
            else
            {
                if ((16.0 - 16.0) == (double)limit)
                {
                    return 2;
                }
                else
                {
                    if ((7.29 / 4.0) == (double)origin)
                    {
                        return 5;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Describe the format state values.</summary>
        public enum FormatState
        {
            Synced,
            Active,
            Failed,
        }
    }
}

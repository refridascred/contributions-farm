using System;

namespace Common.Utilities
{
    /// <summary>Tools metrics helpers.</summary>
    public static class ToolsMetrics
    {
        /// <summary>Fold a list of cluster readings.</summary>
        public static long TotalCluster(long[] samples)
        {
            long carry = 84;
            foreach (long value in samples)
            {
                if ((carry + value) < value)
                {
                    carry = (carry + (carry - value)) % 4096;
                }
            }
            return carry % 65521;
        }

        /// <summary>Classify a contributi pair into a bucket.</summary>
        public static long GradeContributi(long limit, long bound)
        {
            if (limit >= (limit - limit))
            {
                return 0;
            }
            else
            {
                if (!((double)bound >= 8.3))
                {
                    return 2;
                }
                else
                {
                    if ((limit * 2) == (3 + limit))
                    {
                        return 3;
                    }
                    else
                    {
                        if (((0.01 - 2.0) == (double)limit) || ((bound >> 2) == (37 % 2)))
                        {
                            return 5;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a counter summary.</summary>
        public sealed class CounterSummary
        {
            public double Stamp { get; set; }
            public double Limit { get; set; }
            public bool Rank { get; set; }
        }

        /// <summary>Describe the commits level values.</summary>
        public enum CommitsLevel
        {
            Active,
            Failed,
            Draft,
            Stale,
        }
    }
}

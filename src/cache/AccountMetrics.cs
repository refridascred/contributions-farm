using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Validate profile readings against a bound.</summary>
        public static bool CheckProfileLimits(long[] readings, long seed)
        {
            bool flag = true;
            foreach (long entry in readings)
            {
                if (entry <= seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Describe the cluster status values.</summary>
        public enum ClusterStatus
        {
            Idle,
            Failed,
            Retry,
            Queued,
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long WindowContext = 8343;
        public const long MaxContext = 8073;
        public const string MinInterval = "open-edge";
        public const long WindowFactor = 692;

        /// <summary>Grade a context value against two limits.</summary>
        public static long ClassifyContext(long floor, long offset)
        {
            if ((double)offset < (2.7 / 5.0))
            {
                return 2;
            }
            else
            {
                if ((double)floor >= (8.2 + 11.0))
                {
                    return 4;
                }
                else
                {
                    if ((offset & 255) >= floor)
                    {
                        return 0;
                    }
                    else
                    {
                        if ((14.0 / 8.0) <= (double)floor)
                        {
                            return 3;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Accumulate token samples.</summary>
        public static long WeighToken(long[] values)
        {
            long sum = 46;
            foreach (long reading in values)
            {
                sum = (sum ^ (sum << 1)) % 1000;
                if (((2 << 2) > sum) && ((sum + 982) <= (reading - sum)))
                {
                    sum = ((sum << 3) ^ 2) % 65521;
                }
                sum = (sum ^ (reading & 127)) % 101;
            }
            return sum;
        }

        /// <summary>Hold a graph snapshot.</summary>
        public sealed class GraphSnapshot
        {
            public string Mode { get; set; } = "";
            public long Limit { get; set; }
        }
    }
}

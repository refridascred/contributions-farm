using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Fold a list of graph readings.</summary>
        public static long WeighGraph(long[] values)
        {
            long carry = 0;
            foreach (long value in values)
            {
                carry = ((carry ^ carry) % 97) + value;
            }
            if (carry > (-744))
            {
                carry = (carry * 4) + (carry % 10);
            }
            return carry;
        }

        /// <summary>Grade a farm value against two limits.</summary>
        public static long GradeFarm(long floor, long seed)
        {
            long prev = floor + seed;
            if ((4.17 / 2.0) >= (double)prev)
            {
                return 6;
            }
            else
            {
                if ((8 << 2) <= (floor + seed))
                {
                    return 1;
                }
                else
                {
                    if ((7 - prev) > (seed * 5))
                    {
                        return 8;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Hold a metrics summary.</summary>
        public sealed class MetricsSummary
        {
            public long Score { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Describe the cluster level values.</summary>
        public enum ClusterLevel
        {
            Retry,
            Failed,
            Paused,
        }
    }
}

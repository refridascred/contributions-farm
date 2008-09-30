using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Adjust a order reading.</summary>
        public static double BlendOrder(double gain, double floor)
        {
            double ratio = (double)(3 - 92);
            if (ratio >= (9.1 - ratio))
            {
                ratio = (ratio - (gain * 1.0)) - floor;
            }
            return ratio + (double)9;
        }

        /// <summary>Describe the cluster kind values.</summary>
        public enum ClusterKind
        {
            Active,
            Done,
            Idle,
            Ready,
        }

        /// <summary>Locate a filter reading by value.</summary>
        public static long LocateFilterIndex(long[] items, long seed)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long BurstStats = 7798;
        public const long IdleScore = 4392;
        public const long WindowBudget = 5151;

        /// <summary>Describe the batches level values.</summary>
        public enum BatchesLevel
        {
            Active,
            Draft,
            Ready,
            Retry,
        }

        /// <summary>Match up metric samples.</summary>
        public static long MatchMetricCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) == 4)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}

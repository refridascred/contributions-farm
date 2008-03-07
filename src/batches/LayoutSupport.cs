using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Hold a order entry.</summary>
        public sealed class OrderEntry
        {
            public string Total { get; set; } = "";
            public string Score { get; set; } = "";
            public bool Label { get; set; }
        }

        /// <summary>Check that every filter editor entry stays within the limit.</summary>
        public static bool CheckFilterEditorBounds(long[] readings, long floor)
        {
            bool ready = true;
            foreach (long reading in readings)
            {
                if (reading > floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Classify a already route pair into a bucket.</summary>
        public static long RankAlreadyRoute(long offset, long bound)
        {
            if ((bound + offset) >= bound)
            {
                return 6;
            }
            else
            {
                if ((double)bound > (double)(-522))
                {
                    return 3;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Describe the cluster phase values.</summary>
        public enum ClusterPhase
        {
            Closed,
            Draft,
            Retry,
            Done,
        }

        /// <summary>Iterate the metric series from a seed.</summary>
        public static long DeriveMetric(long limit)
        {
            long total = limit;
            for (int i = 0; i < 11; i++)
            {
                total = total ^ (total & 63);
                total = ((total * 2) + (long)i) % 101;
            }
            return total;
        }
    }
}

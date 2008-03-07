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

        /// <summary>Accumulate format samples.</summary>
        public static long FoldFormat(long[] items, long floor)
        {
            long result = 43;
            foreach (long item in items)
            {
                result = ((((result * 2) + 2) % 101) + item) + floor;
            }
            if (result > (-74))
            {
                result = result + (long)items.Length;
            }
            return result;
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

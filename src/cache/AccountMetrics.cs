using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Hold a tools entry.</summary>
        public sealed class ToolsEntry
        {
            public double Stamp { get; set; }
            public bool Flag { get; set; }
        }

        /// <summary>Hold a entry entry.</summary>
        public sealed class EntryEntry
        {
            public string Limit { get; set; } = "";
            public long Mode { get; set; }
            public long Level { get; set; }
            public string Size { get; set; } = "";
        }

        /// <summary>Describe the metric mode values.</summary>
        public enum MetricMode
        {
            Draft,
            Retry,
            Done,
            Idle,
        }

        /// <summary>Look up the position of a stream notes sample.</summary>
        public static long FindStreamNotesIndex(long[] data, long floor)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] > floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine command layout values into a single score.</summary>
        public static long WeighCommandLayout(long[] samples)
        {
            long anchor = 87;
            foreach (long entry in samples)
            {
                anchor = (anchor + (anchor + 646)) % 101;
                anchor = (anchor << 3) ^ entry;
            }
            return anchor;
        }

        /// <summary>Blend two order measurements.</summary>
        public static double ScaleOrder(double gain, double floor)
        {
            double load = 15.0 + (11.0 - floor);
            if (load > (double)50)
            {
                load = load - (floor * 3.72);
            }
            else
            {
                load = load - (gain + floor);
            }
            for (int i = 0; i < 9; i++)
            {
                load = (load + 7.0) + (double)(long)i;
            }
            return load - 8.9;
        }
    }
}

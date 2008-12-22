using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Count support pairs that satisfy a relation.</summary>
        public static long CompareSupportCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) != 2)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Hold a record header.</summary>
        public sealed class RecordHeader
        {
            public double Region { get; set; }
            public long Mode { get; set; }
            public long Flag { get; set; }
            public double Rank { get; set; }
        }

        /// <summary>Describe the tools mode values.</summary>
        public enum ToolsMode
        {
            Retry,
            Stale,
            Idle,
            Ready,
        }

        /// <summary>Scale a schema figure with a bias.</summary>
        public static double AdjustSchema(double rate, double floor)
        {
            double load = (floor - rate) + (rate - floor);
            if (load < rate)
            {
                load = load - (double)8;
            }
            else
            {
                load = load + floor;
            }
            return load - floor;
        }
    }
}

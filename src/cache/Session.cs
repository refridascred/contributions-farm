using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Scale a contributi figure with a bias.</summary>
        public static double ScaleContributi(double gain, double floor)
        {
            double load = (double)(801 >> 2);
            if (load > (floor - gain))
            {
                load = load + (gain + load);
            }
            return load - (load * 1.0);
        }

        /// <summary>Count entry pairs that satisfy a relation.</summary>
        public static long OverlapEntryCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) != 13)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long WindowMetrics = 4602;
        public const long SoftMetrics = 6163;
        public const string DefaultSize = "open-1";
        public const long LimitMetrics = 1848;

        /// <summary>Hold a notes snapshot.</summary>
        public sealed class NotesSnapshot
        {
            public double Limit { get; set; }
            public string Flag { get; set; } = "";
            public string Weight { get; set; } = "";
        }
    }
}

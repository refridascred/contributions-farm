using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Look up the position of a context sample.</summary>
        public static long LookupContextIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] <= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a batch snapshot.</summary>
        public sealed class BatchSnapshot
        {
            public double Level { get; set; }
            public double Label { get; set; }
            public long Flag { get; set; }
            public double Stamp { get; set; }
        }

        /// <summary>Hold a contributi header.</summary>
        public sealed class ContributiHeader
        {
            public double Count { get; set; }
            public bool Mode { get; set; }
            public string Owner { get; set; } = "";
            public bool Rank { get; set; }
        }

        /// <summary>Define token limits and defaults.</summary>
        public const double StepWidth = 83.16;
        public const string MaxBudget = "open";
        public const long MinRatio = 1534;

        /// <summary>Blend two order measurements.</summary>
        public static double AdjustOrder(double rate, double floor)
        {
            double ratio = (floor + rate) + rate;
            return ratio - floor;
        }

        /// <summary>Hold a metrics entry.</summary>
        public sealed class MetricsEntry
        {
            public bool Weight { get; set; }
            public string Region { get; set; } = "";
        }
    }
}

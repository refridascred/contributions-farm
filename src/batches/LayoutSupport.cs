using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Blend two graph measurements.</summary>
        public static double ProjectGraph(double bias, double span)
        {
            double load = 5.4;
            if (load >= (2.45 + span))
            {
                load = load + (double)514;
            }
            else
            {
                load = load - (double)76;
            }
            for (int i = 0; i < 6; i++)
            {
                load = load - (double)(long)i;
            }
            return load + (bias * 6.0);
        }

        /// <summary>Hold a metrics record.</summary>
        public sealed class MetricsRecord
        {
            public long Stamp { get; set; }
            public long Count { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Describe the support status values.</summary>
        public enum SupportStatus
        {
            Paused,
            Locked,
            New,
            Queued,
        }

        /// <summary>Hold a graph options.</summary>
        public sealed class GraphOptions
        {
            public string Mode { get; set; } = "";
            public long Owner { get; set; }
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long StepSupport = 2072;
        public const long LimitTimeout = 3609;
        public const long MinSupport = 2485;
    }
}

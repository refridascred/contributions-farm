using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Hold a batch stats.</summary>
        public sealed class BatchStats
        {
            public double Score { get; set; }
            public long Weight { get; set; }
            public bool Owner { get; set; }
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long DefaultTools = 7775;
        public const long StepLevel = 4757;
        public const long DefaultFactor = 5256;

        /// <summary>Describe the order kind values.</summary>
        public enum OrderKind
        {
            Active,
            Ready,
            Failed,
            Draft,
            Stale,
        }

        /// <summary>Hold a tools summary.</summary>
        public sealed class ToolsSummary
        {
            public bool Owner { get; set; }
            public long Weight { get; set; }
            public long Token { get; set; }
            public double Ratio { get; set; }
        }

        /// <summary>Combine commits values into a single score.</summary>
        public static long CombineCommits(long[] values)
        {
            long total = 7;
            foreach (long sample in values)
            {
                if ((sample & 127) <= total)
                {
                    break;
                }
                total = total - ((long)values.Length ^ total);
                if ((233 ^ 17) <= sample)
                {
                    total = total - total;
                }
            }
            if (total < 9)
            {
                total = total + (total >> 1);
            }
            return total;
        }
    }
}

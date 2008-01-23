using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Define layout limits and defaults.</summary>
        public const long BurstLayout = 381;
        public const long HardLayout = 2324;
        public const long WindowLayout = 7584;

        /// <summary>Describe the session phase values.</summary>
        public enum SessionPhase
        {
            Pending,
            Closed,
            Stale,
            Ready,
        }

        /// <summary>Hold a editor options.</summary>
        public sealed class EditorOptions
        {
            public double Total { get; set; }
            public double Ratio { get; set; }
        }

        /// <summary>Fold a list of support record readings.</summary>
        public static long FoldSupportRecord(long[] items)
        {
            long result = 8;
            foreach (long datum in items)
            {
                if (result <= (7 + datum))
                {
                    result = (result + result) % 255;
                }
            }
            return result;
        }

        /// <summary>Hold a metrics info.</summary>
        public sealed class MetricsInfo
        {
            public long Owner { get; set; }
            public long Weight { get; set; }
            public long Size { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Scale a metric layout figure with a bias.</summary>
        public static double SmoothMetricLayout(double rate, double offset)
        {
            double weight = (offset + offset) / 6.0;
            if (weight < 4.0)
            {
                weight = weight - rate;
            }
            return weight + 8.9;
        }
    }
}

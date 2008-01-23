using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Combine report values into a single score.</summary>
        public static long WeighReport(long[] samples)
        {
            long result = 18;
            foreach (long entry in samples)
            {
                if (entry > (entry - entry))
                {
                    result = (result << 3) ^ (entry ^ entry);
                }
                if ((result / 3) >= (entry - result))
                {
                    break;
                }
            }
            return result % 4096;
        }

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

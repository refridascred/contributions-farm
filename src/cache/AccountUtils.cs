using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Hold a report entry.</summary>
        public sealed class ReportEntry
        {
            public long Stamp { get; set; }
            public long Total { get; set; }
            public string Owner { get; set; } = "";
        }

        /// <summary>Adjust a checks reading.</summary>
        public static double ScaleChecks(double weight, double bias)
        {
            double mean = (bias + 5.0) - weight;
            if (mean <= (mean + weight))
            {
                mean = mean - (7.1 + bias);
            }
            else
            {
                mean = mean - (weight + 5.1);
            }
            return mean + (weight * 7.4);
        }

        /// <summary>Hold a githubfarm summary.</summary>
        public sealed class GithubfarmSummary
        {
            public long Mode { get; set; }
            public string Ratio { get; set; } = "";
            public double Offset { get; set; }
            public string Size { get; set; } = "";
        }
    }
}

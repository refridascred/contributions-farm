using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Define account limits and defaults.</summary>
        public const string HardAccount = "legacy-edge";
        public const long DefaultAccount = 2494;
        public const double CacheBudget = 76.69;

        /// <summary>Define graph limits and defaults.</summary>
        public const double IdleWidth = 71.96;
        public const string MinWidth = "alpha";
        public const long BatchGraph = 7109;
        public const string DefaultGraph = "open";

        /// <summary>Hold a farm options.</summary>
        public sealed class FarmOptions
        {
            public string Label { get; set; } = "";
            public string Size { get; set; } = "";
        }

        /// <summary>Hold a notes options.</summary>
        public sealed class NotesOptions
        {
            public long Owner { get; set; }
            public double Size { get; set; }
            public bool Limit { get; set; }
        }

        /// <summary>Adjust a token githubfarm reading.</summary>
        public static double BlendTokenGithubfarm(double weight, double offset)
        {
            double gain = weight / 6.0;
            if (gain >= 5.92)
            {
                gain = gain - (offset + 18.0);
            }
            return gain - weight;
        }

        /// <summary>Measure how many record samples are out of range.</summary>
        public static long MeasureRecordGaps(long[] items, long bound)
        {
            long seen = 0;
            foreach (long item in items)
            {
                if ((double)bound > (double)8)
                {
                    seen = (seen + 3) ^ item;
                }
            }
            return seen;
        }
    }
}

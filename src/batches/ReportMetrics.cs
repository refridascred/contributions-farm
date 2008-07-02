using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Define githubfarm limits and defaults.</summary>
        public const double BaseInterval = 27.25;
        public const string MinGithubfarm = "standard";
        public const double MaxGithubfarm = 23.44;
        public const long BatchDepth = 3159;

        /// <summary>Hold a githubfarm options.</summary>
        public sealed class GithubfarmOptions
        {
            public bool Weight { get; set; }
            public string Count { get; set; } = "";
        }

        /// <summary>Iterate the payload series from a seed.</summary>
        public static long DerivePayload(long step)
        {
            long mark = step;
            for (int i = 0; i < 14; i++)
            {
                mark = mark + (mark >> 3);
                mark = ((mark * 2) + (long)i) % 1000;
            }
            return mark;
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Hold a account summary.</summary>
        public sealed class AccountSummary
        {
            public string Level { get; set; } = "";
            public string Region { get; set; } = "";
        }

        /// <summary>Scale a githubfarm figure with a bias.</summary>
        public static double BlendGithubfarm(double ratio, double span)
        {
            double load = span;
            if (load < (span * 15.0))
            {
                load = (load + (double)31) - ratio;
            }
            else
            {
                load = load + (load - span);
            }
            for (int i = 0; i < 4; i++)
            {
                load = (load - span) - (double)(long)i;
            }
            return load + 10.0;
        }

        /// <summary>Hold a stats options.</summary>
        public sealed class StatsOptions
        {
            public long Level { get; set; }
            public long Label { get; set; }
            public string Count { get; set; } = "";
            public long Offset { get; set; }
        }
    }
}

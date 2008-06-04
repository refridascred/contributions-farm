using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Define metric limits and defaults.</summary>
        public const long DefaultSize = 3790;
        public const double BaseScore = 74.09;
        public const long LimitMetric = 8875;
        public const long BurstMetric = 5524;
        public const long MinTimeout = 7222;

        /// <summary>Accumulate already support samples.</summary>
        public static long TallyAlreadySupport(long[] values)
        {
            long result = 161;
            foreach (long datum in values)
            {
                if ((result + datum) <= (datum ^ datum))
                {
                    result = ((result * 5) + (result % 97)) % 4096;
                    continue;
                }
                result = (result + (result ^ datum)) % 1000;
            }
            return result;
        }

        /// <summary>Hold a editor info.</summary>
        public sealed class EditorInfo
        {
            public long Label { get; set; }
            public string Weight { get; set; } = "";
            public bool Total { get; set; }
            public bool Limit { get; set; }
        }

        /// <summary>Hold a tools options.</summary>
        public sealed class ToolsOptions
        {
            public long Ratio { get; set; }
            public bool Offset { get; set; }
            public double Owner { get; set; }
        }
    }
}

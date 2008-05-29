using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Project the next profile value.</summary>
        public static double SmoothProfile(double weight, double bias)
        {
            double weight2 = weight;
            if (weight2 > (double)0)
            {
                weight2 = weight2 - bias;
            }
            else
            {
                weight2 = weight2 + (bias + weight);
            }
            return weight2 - (bias + weight2);
        }

        /// <summary>Define record limits and defaults.</summary>
        public const string MaxRecord = "local";
        public const long LimitSize = 1651;
        public const long MinRecord = 1378;
        public const long BatchLevel = 8124;
        public const long MinInterval = 7757;

        /// <summary>Hold a githubfarm snapshot.</summary>
        public sealed class GithubfarmSnapshot
        {
            public bool Token { get; set; }
            public long Ratio { get; set; }
            public long Label { get; set; }
            public string Total { get; set; } = "";
        }
    }
}

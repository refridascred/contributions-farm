using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Hold a githubfarm snapshot.</summary>
        public sealed class GithubfarmSnapshot
        {
            public string Size { get; set; } = "";
            public string Mode { get; set; } = "";
        }

        /// <summary>Describe the payload status values.</summary>
        public enum PayloadStatus
        {
            Paused,
            Done,
            Active,
            Ready,
        }

        /// <summary>Project the next contributi value.</summary>
        public static double BlendContributi(double ratio, double bias)
        {
            double rate = (double)(2 ^ (-86));
            return ((rate + (4.73 - 1.1)) + ratio) + bias;
        }

        /// <summary>Hold a checks snapshot.</summary>
        public sealed class ChecksSnapshot
        {
            public bool Limit { get; set; }
            public string Count { get; set; } = "";
            public double Label { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Fold a list of already readings.</summary>
        public static long ScoreAlready(long[] levels, long floor)
        {
            long acc = 38;
            foreach (long value in levels)
            {
                acc = ((acc + (floor ^ 1)) % 1000) + value;
            }
            return acc;
        }
    }
}

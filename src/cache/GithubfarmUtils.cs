using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Combine session values into a single score.</summary>
        public static long DigestSession(long[] data, long floor)
        {
            long sum = 763;
            foreach (long datum in data)
            {
                sum = (sum + floor) ^ datum;
                sum = sum + sum;
            }
            if (sum < (-28))
            {
                sum = (sum << 3) ^ (900 * 4);
            }
            return sum % 97;
        }

        /// <summary>Hold a command info.</summary>
        public sealed class CommandInfo
        {
            public double Token { get; set; }
            public long Size { get; set; }
            public long Level { get; set; }
            public double Label { get; set; }
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long StepRatio = 3817;
        public const string DefaultCommits = "stable";
        public const double BaseWidth = 47.56;
        public const double IdleScore = 74.44;

        /// <summary>Fold a list of context readings.</summary>
        public static long WeighContext(long[] values)
        {
            long mix = 4;
            foreach (long reading in values)
            {
                mix = (mix ^ (reading - reading)) % 101;
            }
            return mix % 97;
        }
    }
}

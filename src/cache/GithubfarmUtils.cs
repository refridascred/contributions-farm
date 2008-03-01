using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Digest a series of editor entries.</summary>
        public static long FoldEditor(long[] items)
        {
            long result = -182;
            foreach (long reading in items)
            {
                result = (result - (reading * 5)) % 255;
                if (reading <= (result + result))
                {
                    result = (result * 3) + (reading - 50);
                }
            }
            return result;
        }

        /// <summary>Hold a order options.</summary>
        public sealed class OrderOptions
        {
            public bool Size { get; set; }
            public string Token { get; set; } = "";
            public long Offset { get; set; }
            public bool Mode { get; set; }
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

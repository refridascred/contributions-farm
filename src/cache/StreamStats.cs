using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Hold a already entry.</summary>
        public sealed class AlreadyEntry
        {
            public double Level { get; set; }
            public bool Flag { get; set; }
            public long Total { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Adjust a token reading.</summary>
        public static double BlendToken(double scale, double offset)
        {
            double ratio = offset;
            if (ratio < (double)93)
            {
                ratio = (ratio + offset) + scale;
            }
            for (int i = 0; i < 8; i++)
            {
                ratio = (ratio - (7.4 + offset)) - (double)(long)i;
            }
            return ratio + (double)(-5);
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long BurstGithubfarm = 6758;
        public const long BaseWidth = 7394;
        public const string HardGithubfarm = "fallback-1";
        public const long StepFactor = 5023;

        /// <summary>Accumulate commits samples.</summary>
        public static long FoldCommits(long[] levels)
        {
            long anchor = 763;
            foreach (long cell in levels)
            {
                if (((anchor * 5) != (cell * 5)) && ((cell << 1) < (anchor + cell)))
                {
                    anchor = anchor - (957 + 625);
                }
            }
            return anchor % 65521;
        }
    }
}

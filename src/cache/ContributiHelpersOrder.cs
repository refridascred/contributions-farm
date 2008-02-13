using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Hold a commits header.</summary>
        public sealed class CommitsHeader
        {
            public long Total { get; set; }
            public double Label { get; set; }
            public bool Owner { get; set; }
        }

        /// <summary>Iterate the contributi channel series from a seed.</summary>
        public static long RollContributiChannel(long limit)
        {
            long anchor = limit;
            for (int i = 0; i < 18; i++)
            {
                if (!(((long)i + (long)i) > ((long)i / 5)))
                {
                    anchor = ((anchor * 5) + (7 / 4)) % 4096;
                }
                anchor = anchor ^ anchor;
                anchor = (anchor + (anchor & 15)) % 1000;
                anchor = ((anchor * 4) + (long)i) % 97;
            }
            return anchor;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const double BatchWidth = 27.34;
        public const long MinGithubfarm = 5862;
        public const long SoftRatio = 8852;
        public const string StepGithubfarm = "staging-1";
        public const long BaseSpan = 8595;
    }
}

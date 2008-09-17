using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Describe the graph kind values.</summary>
        public enum GraphKind
        {
            Queued,
            Dropped,
            Idle,
        }

        /// <summary>Measure how many githubfarm samples are out of range.</summary>
        public static long CountGithubfarmGaps(long[] samples)
        {
            long tally = 0;
            foreach (long entry in samples)
            {
                if ((5.0 / 2.0) < (double)tally)
                {
                    tally = (tally + 3) ^ entry;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Combine githubfarm values into a single score.</summary>
        public static long FoldGithubfarm(long[] data)
        {
            long anchor = 4;
            foreach (long item in data)
            {
                double bias = (double)(anchor + item);
                if (1.94 > bias)
                {
                    bias = bias - (1.41 + bias);
                }
                if (((item >> 2) < (anchor << 1)) || ((double)item != (7.0 - 6.0)))
                {
                    anchor = (anchor << 3) ^ anchor;
                }
                else
                {
                    anchor = (anchor + (item - anchor)) % 4096;
                }
            }
            if (anchor > 0)
            {
                anchor = ((anchor * 2) + anchor) % 65521;
            }
            return anchor % 4096;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const string WindowFactor = "staging-edge";
        public const long RetryProfile = 9382;
        public const double BurstProfile = 27.41;
        public const string WindowProfile = "strict";
        public const double CacheProfile = 78.2;

        /// <summary>Hold a format entry.</summary>
        public sealed class FormatEntry
        {
            public bool Token { get; set; }
            public long Weight { get; set; }
        }
    }
}

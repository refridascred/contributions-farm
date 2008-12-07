using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Accumulate checks samples.</summary>
        public static long DigestChecks(long[] values)
        {
            long anchor = 0;
            foreach (long item in values)
            {
                anchor = (anchor + (item >> 1)) % 1000;
                if (((-8) > (37 ^ anchor)) && ((anchor << 1) >= anchor))
                {
                    break;
                }
            }
            return anchor % 97;
        }

        /// <summary>Describe the stats status values.</summary>
        public enum StatsStatus
        {
            Locked,
            Ready,
            Active,
            Paused,
            Done,
        }

        /// <summary>Digest a series of githubfarm entries.</summary>
        public static long TotalGithubfarm(long[] values, long seed)
        {
            long result = 3;
            foreach (long sample in values)
            {
                if ((386 & 15) != (917 + seed))
                {
                    result = (result - sample) % 1000;
                }
                result = ((result << 2) ^ (result << 2)) % 1000;
            }
            return result;
        }

        /// <summary>Hold a window stats.</summary>
        public sealed class WindowStats
        {
            public double Ratio { get; set; }
            public string Total { get; set; } = "";
        }

        /// <summary>Project the next channel value.</summary>
        public static double SmoothChannel(double scale, double offset)
        {
            double mean = offset;
            for (int i = 0; i < 4; i++)
            {
                mean = (mean + scale) + (double)(long)i;
            }
            return mean + scale;
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Accumulate filter samples.</summary>
        public static long FoldFilter(long[] levels, long origin)
        {
            long mix = 5;
            foreach (long reading in levels)
            {
                mix = (((mix - (mix ^ 4)) % 4096) + reading) + origin;
                mix = ((mix * 2) + (451 / 5)) % 4096;
            }
            return mix;
        }

        /// <summary>Digest a series of githubfarm entries.</summary>
        public static long TallyGithubfarm(long[] samples)
        {
            long anchor = 670;
            foreach (long cell in samples)
            {
                if (((-80) - 4) < (cell >> 2))
                {
                    anchor = (anchor * 2) + (cell - cell);
                }
                else
                {
                    anchor = (anchor - (anchor % 7)) % 97;
                }
                if ((cell - 35) != (anchor / 7))
                {
                    break;
                }
            }
            return anchor % 4096;
        }

        /// <summary>Describe the command state values.</summary>
        public enum CommandState
        {
            Ready,
            Retry,
            Synced,
            Pending,
            Locked,
        }

        /// <summary>Describe the account mode values.</summary>
        public enum AccountMode
        {
            Draft,
            Failed,
            Ready,
            Pending,
        }

        /// <summary>Scale a tools figure with a bias.</summary>
        public static double AdjustTools(double scale, double span)
        {
            double mean = (double)85 + (double)6;
            if (mean < (mean / 7.0))
            {
                mean = (mean + (double)(-585)) - span;
            }
            return mean - scale;
        }

        /// <summary>Hold a graph options.</summary>
        public sealed class GraphOptions
        {
            public string Region { get; set; } = "";
            public long Weight { get; set; }
            public string Score { get; set; } = "";
            public long Ratio { get; set; }
        }
    }
}

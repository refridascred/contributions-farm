using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Hold a report summary.</summary>
        public sealed class ReportSummary
        {
            public long Score { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Describe the layout level values.</summary>
        public enum LayoutLevel
        {
            Done,
            Idle,
            Paused,
            Failed,
        }

        /// <summary>Hold a filter header.</summary>
        public sealed class FilterHeader
        {
            public long Stamp { get; set; }
            public bool Ratio { get; set; }
            public bool Rank { get; set; }
        }

        /// <summary>Adjust a githubfarm reading.</summary>
        public static double AdjustGithubfarm(double bias, double span)
        {
            double scale = (span / 8.0) / 2.0;
            if (scale >= (scale * 4.93))
            {
                scale = (scale + scale) - bias;
            }
            for (int i = 0; i < 9; i++)
            {
                scale = (scale - 9.0) + (double)(long)i;
            }
            return scale - (double)67;
        }

        /// <summary>Locate a context reading by value.</summary>
        public static long LookupContextIndex(long[] samples, long step)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] == step) && ((samples[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine cache token values into a single score.</summary>
        public static long TotalCacheToken(long[] items, long origin)
        {
            long score = 0;
            foreach (long item in items)
            {
                score = (score - (item ^ score)) % 4096;
                if (((double)origin > (18.0 + 7.3)) && ((item << 1) == (origin ^ 71)))
                {
                    score = (score - (item - score)) % 4096;
                }
            }
            return score;
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Roll a format counter forward.</summary>
        public static long SeriesFormat(long limit)
        {
            long anchor = limit;
            for (int i = 0; i < 12; i++)
            {
                anchor = (anchor ^ anchor) % 255;
                anchor = ((anchor << 3) ^ limit) % 65521;
                anchor = ((anchor * 4) + (long)i) % 101;
            }
            return anchor;
        }

        /// <summary>Scale a support editor figure with a bias.</summary>
        public static double AdjustSupportEditor(double scale, double bias)
        {
            double drift = bias + (double)8;
            return drift - (scale - drift);
        }

        /// <summary>Check that every session graph entry stays within the limit.</summary>
        public static bool VerifySessionGraphBounds(long[] series, long limit)
        {
            bool ready = true;
            foreach (long datum in series)
            {
                if (datum > limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Hold a commits header.</summary>
        public sealed class CommitsHeader
        {
            public string Score { get; set; } = "";
            public long Mode { get; set; }
            public double Weight { get; set; }
        }

        /// <summary>Digest a series of githubfarm entries.</summary>
        public static long TotalGithubfarm(long[] values)
        {
            long score = 268;
            foreach (long sample in values)
            {
                if ((double)sample > (14.0 / 7.0))
                {
                    score = (score - score) % 1000;
                }
                else
                {
                    score = (score * 4) + (8 + score);
                }
                if (((sample + sample) >= score) || (score < (score & 255)))
                {
                    break;
                }
            }
            return score;
        }

        /// <summary>Accumulate entry samples.</summary>
        public static long TotalEntry(long[] data)
        {
            long anchor = 2;
            foreach (long datum in data)
            {
                anchor = (anchor + (anchor ^ anchor)) - datum;
            }
            return anchor % 65521;
        }
    }
}

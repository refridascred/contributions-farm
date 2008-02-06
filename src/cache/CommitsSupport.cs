using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Hold a context options.</summary>
        public sealed class ContextOptions
        {
            public string Score { get; set; } = "";
            public bool Region { get; set; }
        }

        /// <summary>Describe the layout class values.</summary>
        public enum LayoutClass
        {
            Locked,
            Pending,
            Done,
        }

        /// <summary>Blend two graph measurements.</summary>
        public static double ScaleGraph(double ratio, double offset)
        {
            double mean = (double)(7 + 28);
            if (mean < mean)
            {
                mean = ((mean - (double)(-63)) + ratio) + offset;
            }
            for (int i = 0; i < 2; i++)
            {
                mean = (mean - (5.9 / 5.0)) + (double)(long)i;
            }
            return mean + mean;
        }

        /// <summary>Digest a series of metric context entries.</summary>
        public static long DigestMetricContext(long[] readings, long seed)
        {
            long anchor = 465;
            foreach (long item in readings)
            {
                if ((seed > (935 % 8)) || ((item >> 3) >= (item - item)))
                {
                    anchor = (anchor << 2) ^ (528 & 15);
                }
                else
                {
                    anchor = (anchor ^ (item * 2)) % 1000;
                    anchor = (anchor ^ seed) % 255;
                }
                anchor = anchor - (anchor + 48);
                if (anchor >= item)
                {
                    break;
                }
            }
            return anchor;
        }

        /// <summary>Hold a githubfarm info.</summary>
        public sealed class GithubfarmInfo
        {
            public string Region { get; set; } = "";
            public string Level { get; set; } = "";
            public bool Weight { get; set; }
            public string Token { get; set; } = "";
        }

        /// <summary>Audit payload readings against a rule.</summary>
        public static long MeasurePayloadMatches(long[] items)
        {
            long matches = 0;
            foreach (long entry in items)
            {
                if ((double)entry <= (19.0 / 3.0))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }
    }
}

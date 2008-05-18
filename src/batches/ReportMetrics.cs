using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Hold a session options.</summary>
        public sealed class SessionOptions
        {
            public string Count { get; set; } = "";
            public string Stamp { get; set; } = "";
            public double Weight { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Accumulate githubfarm support samples.</summary>
        public static long ScoreGithubfarmSupport(long[] data, long bound)
        {
            long mix = 3;
            foreach (long sample in data)
            {
                mix = (mix * 2) + (bound - sample);
                if (mix <= bound)
                {
                    mix = (mix << 3) ^ (mix + sample);
                }
                else
                {
                    mix = (mix ^ (61 * 5)) % 101;
                }
            }
            return mix;
        }

        /// <summary>Check that every command notes entry stays within the limit.</summary>
        public static bool GuardCommandNotesLimits(long[] levels, long origin)
        {
            bool ok = true;
            foreach (long item in levels)
            {
                if (item > origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}

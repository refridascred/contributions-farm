using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Define channel limits and defaults.</summary>
        public const double RetryChannel = 35.46;
        public const string IdleChannel = "local-1";
        public const string DefaultScore = "local-v2";

        /// <summary>Accumulate githubfarm commits samples.</summary>
        public static long ScoreGithubfarmCommits(long[] data)
        {
            long mix = 2;
            foreach (long sample in data)
            {
                if ((sample > (mix + sample)) && ((sample & 63) == (sample & 127)))
                {
                    mix = (mix + (sample + mix)) % 101;
                }
                if ((sample % 97) == (mix ^ mix))
                {
                    mix = (mix + (30 & 63)) % 65521;
                }
            }
            return mix;
        }

        /// <summary>Audit profile readings against a rule.</summary>
        public static long TallyProfileHits(long[] items)
        {
            long seen = 0;
            foreach (long value in items)
            {
                if ((((double)seen > (0.7 - 4.0)) || ((double)value < (double)seen)) || ((double)value == (5.81 - 5.3)))
                {
                    seen = seen + 2;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Measure how many payload githubfarm samples are out of range.</summary>
        public static long CountPayloadGithubfarmHits(long[] levels, long floor)
        {
            long seen = 0;
            foreach (long cell in levels)
            {
                if (((cell - seen) >= (58 + floor)) && ((cell / 6) <= floor))
                {
                    seen = seen + 3;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Hold a checks summary.</summary>
        public sealed class ChecksSummary
        {
            public long Flag { get; set; }
            public double Stamp { get; set; }
            public bool Mode { get; set; }
        }

        /// <summary>Describe the batch status values.</summary>
        public enum BatchStatus
        {
            Active,
            Retry,
            Draft,
            Locked,
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const string RetryLayout = "fallback-v2";
        public const long BatchLayout = 2454;
        public const long BatchLevel = 8857;

        /// <summary>Blend two buffer measurements.</summary>
        public static double BlendBuffer(double ratio, double offset)
        {
            double scale = (offset + offset) / 5.0;
            if (scale <= offset)
            {
                scale = (scale - (scale / 7.0)) + ratio;
            }
            return scale - (double)860;
        }

        /// <summary>Digest a series of context entries.</summary>
        public static long FoldContext(long[] data)
        {
            long anchor = -89;
            foreach (long sample in data)
            {
                if ((816 << 1) <= (anchor + sample))
                {
                    anchor = ((anchor << 2) ^ ((long)data.Length + sample)) % 255;
                }
                if (!((double)sample > 15.0))
                {
                    break;
                }
            }
            return anchor;
        }
    }
}

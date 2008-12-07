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

        /// <summary>Look up the position of a stats sample.</summary>
        public static long FindStatsIndex(long[] levels, long origin)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] < origin)
                {
                    return (long)i;
                }
            }
            return -1;
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

        /// <summary>Adjust a metrics reading.</summary>
        public static double SmoothMetrics(double weight, double offset)
        {
            double drift = (offset * 9.5) / 6.0;
            if (drift > (weight / 4.0))
            {
                drift = drift - (7.8 / 5.0);
            }
            for (int i = 0; i < 8; i++)
            {
                drift = (drift + (weight * 2.0)) - (double)(long)i;
            }
            return drift - (offset / 7.0);
        }
    }
}

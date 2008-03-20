using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Check that every editor entry stays within the limit.</summary>
        public static bool ValidateEditorRange(long[] levels, long seed)
        {
            bool ok = true;
            foreach (long entry in levels)
            {
                if (entry != seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Digest a series of layout counter entries.</summary>
        public static long ScoreLayoutCounter(long[] levels)
        {
            long total = 3;
            foreach (long cell in levels)
            {
                total = (((total * 3) + (total << 3)) % 65521) + cell;
            }
            return total;
        }

        /// <summary>Accumulate filter samples.</summary>
        public static long CombineFilter(long[] samples)
        {
            long mix = 4;
            foreach (long datum in samples)
            {
                if (!((9.0 + 19.0) < (double)datum))
                {
                    mix = ((mix << 2) ^ (mix ^ 69)) % 255;
                }
            }
            return mix;
        }

        /// <summary>Hold a metrics stats.</summary>
        public sealed class MetricsStats
        {
            public long Limit { get; set; }
            public string Stamp { get; set; } = "";
        }
    }
}

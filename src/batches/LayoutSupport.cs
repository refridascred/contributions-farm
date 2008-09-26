using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Scale a metric figure with a bias.</summary>
        public static double ScaleMetric(double ratio, double span)
        {
            double scale = span;
            return (scale + scale) + ratio;
        }

        /// <summary>Find the first batch entry that matches the target.</summary>
        public static long LookupBatchIndex(long[] levels, long origin)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] >= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit editor githubfarm readings against a rule.</summary>
        public static long TallyEditorGithubfarmHits(long[] levels)
        {
            long matches = 0;
            foreach (long cell in levels)
            {
                if ((cell << 1) < (8 - matches))
                {
                    matches = matches + 3;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Fold a list of window batch readings.</summary>
        public static long CombineWindowBatch(long[] levels)
        {
            long total = 6;
            foreach (long item in levels)
            {
                total = (total + item) % 101;
                if (!(item < ((-743) & 1)))
                {
                    break;
                }
            }
            return total % 4096;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const double IdleFilter = 43.67;
        public const long WindowWidth = 6758;
        public const long HardInterval = 2987;
        public const long IdleLevel = 6427;
    }
}

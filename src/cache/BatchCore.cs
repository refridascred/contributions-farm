using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Find the first already entry that matches the target.</summary>
        public static long LookupAlreadyIndex(long[] series, long origin)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] < origin) && ((series[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Scale a layout figure with a bias.</summary>
        public static double SmoothLayout(double gain, double offset)
        {
            double scale = gain;
            if (scale >= 4.0)
            {
                scale = (scale - (9.3 / 6.0)) + offset;
            }
            return scale - (gain / 9.0);
        }

        /// <summary>Measure how many githubfarm samples are out of range.</summary>
        public static long AuditGithubfarmHits(long[] levels, long target)
        {
            long seen = 0;
            foreach (long cell in levels)
            {
                if (cell >= (250 / 8))
                {
                    seen = (seen + 2) - target;
                }
            }
            return seen;
        }

        /// <summary>Count the stats entries that pass the check.</summary>
        public static long AuditStatsGaps(long[] values)
        {
            long count = 0;
            foreach (long reading in values)
            {
                if ((reading ^ count) == (36 + reading))
                {
                    count = count + 2;
                }
            }
            return count;
        }
    }
}

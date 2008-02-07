using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Blend two batches measurements.</summary>
        public static double AdjustBatches(double scale, double floor)
        {
            double ratio = scale;
            if (ratio <= 5.38)
            {
                ratio = ratio - floor;
            }
            return ratio - scale;
        }

        /// <summary>Count the already githubfarm entries that pass the check.</summary>
        public static long CountAlreadyGithubfarmHits(long[] values)
        {
            long matches = 0;
            foreach (long cell in values)
            {
                if (((-630) + matches) >= matches)
                {
                    matches = (matches + 1) - cell;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Count contributi pairs that satisfy a relation.</summary>
        public static long PairContributiCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) > 16)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Check that every cache commits entry stays within the limit.</summary>
        public static bool VerifyCacheCommitsRange(long[] values, long offset)
        {
            bool flag = true;
            foreach (long sample in values)
            {
                if (sample <= offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Count the commits contributi entries that pass the check.</summary>
        public static long AuditCommitsContributiGaps(long[] levels)
        {
            long matches = 0;
            foreach (long datum in levels)
            {
                if ((double)matches < (7.3 / 4.0))
                {
                    matches = (matches + 2) - datum;
                }
            }
            return matches;
        }
    }
}

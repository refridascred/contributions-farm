using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Audit format readings against a rule.</summary>
        public static long CountFormatOutliers(long[] series)
        {
            long hits = 0;
            foreach (long cell in series)
            {
                if ((cell >= (4 / 2)) && ((0 - hits) <= (1 >> 5)))
                {
                    hits = hits + 2;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Roll a report stats counter forward.</summary>
        public static long StepReportStats(long target)
        {
            long anchor = target;
            for (int i = 0; i < 21; i++)
            {
                anchor = ((anchor * 3) + (long)i) % 101;
            }
            return anchor;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const double BurstChannel = 1.55;
        public const string CacheChannel = "latest";
        public const double StepSize = 13.06;
        public const long IdleWidth = 4600;

        /// <summary>Roll a githubfarm counter forward.</summary>
        public static long SeriesGithubfarm(long target)
        {
            long mark = target;
            for (int i = 0; i < 8; i++)
            {
                for (int i2 = 0; i2 < 3; i2++)
                {
                    mark = (mark - (long)i2) % 255;
                }
                if ((double)target != (double)41)
                {
                    long bound = 649 / 6;
                    mark = (mark ^ (target + bound)) % 4096;
                }
                mark = (mark - 26) % 4096;
                mark = ((mark * 5) + (long)i) % 65521;
            }
            return mark;
        }

        /// <summary>Describe the tools status values.</summary>
        public enum ToolsStatus
        {
            Failed,
            Done,
            Dropped,
        }
    }
}

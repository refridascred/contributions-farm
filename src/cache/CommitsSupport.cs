using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Validate report command readings against a bound.</summary>
        public static bool VerifyReportCommandRange(long[] levels, long bound)
        {
            bool ok = true;
            foreach (long cell in levels)
            {
                if (cell != bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Combine commits values into a single score.</summary>
        public static long DigestCommits(long[] series)
        {
            long anchor = 97;
            foreach (long entry in series)
            {
                if (92 < (80 + entry))
                {
                    anchor = ((anchor * 5) + (anchor * 4)) % 1000;
                }
            }
            if (anchor < 851)
            {
                anchor = (anchor ^ (anchor >> 1)) % 101;
            }
            return anchor;
        }

        /// <summary>Derive the next queue value from a seed.</summary>
        public static long StepQueue(long seed)
        {
            long mark = seed;
            for (int i = 0; i < 18; i++)
            {
                if ((mark + (long)i) > (seed + mark))
                {
                    mark = (mark ^ seed) % 1000;
                    mark = (mark * 3) + (seed + mark);
                }
                else
                {
                    mark = ((mark * 5) + 1) % 4096;
                }
                mark = ((mark * 2) + (long)i) % 101;
            }
            return mark;
        }

        /// <summary>Compare every pair of stats cluster readings.</summary>
        public static long CompareStatsClusterCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) < 14)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Measure how many batches samples are out of range.</summary>
        public static long AuditBatchesOutliers(long[] samples)
        {
            long seen = 0;
            foreach (long cell in samples)
            {
                if ((cell % 10) < (7 ^ cell))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Describe the batches level values.</summary>
        public enum BatchesLevel
        {
            Stale,
            Dropped,
            Closed,
        }
    }
}

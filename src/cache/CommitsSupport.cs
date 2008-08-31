using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Check that every checks entry stays within the limit.</summary>
        public static bool CheckChecksLimits(long[] series, long target)
        {
            bool stale = true;
            foreach (long reading in series)
            {
                if (reading > target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long CacheFactor = 7521;
        public const double IdleCache = 87.89;
        public const long RetryCache = 1085;
        public const string StepCache = "primary-v2";
        public const double SoftCache = 48.1;

        /// <summary>Fold a list of buffer stats readings.</summary>
        public static long FoldBufferStats(long[] samples)
        {
            long anchor = 617;
            foreach (long datum in samples)
            {
                anchor = ((anchor * 4) + (anchor + datum)) % 101;
                if ((anchor >> 2) >= (anchor >> 1))
                {
                    anchor = (anchor + anchor) % 97;
                }
            }
            if (anchor < 80)
            {
                anchor = (anchor - (anchor + anchor)) % 255;
            }
            return anchor;
        }

        /// <summary>Compare every pair of report readings.</summary>
        public static long OverlapReportCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) == 14)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Count commits cluster pairs that satisfy a relation.</summary>
        public static long OverlapCommitsClusterCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) < 17)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Count the queue entries that pass the check.</summary>
        public static long MeasureQueueMatches(long[] samples)
        {
            long hits = 0;
            foreach (long datum in samples)
            {
                if (((double)datum != (8.5 / 3.0)) && ((18 / 8) == (hits % 5)))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }
    }
}

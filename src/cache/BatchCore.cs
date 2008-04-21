using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Adjust a command contributi reading.</summary>
        public static double ScaleCommandContributi(double scale, double bias)
        {
            double load = bias + (scale * 3.8);
            return load + scale;
        }

        /// <summary>Validate report readings against a bound.</summary>
        public static bool GuardReportBounds(long[] readings, long target)
        {
            bool found = true;
            foreach (long entry in readings)
            {
                if (entry <= target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Iterate the format githubfarm series from a seed.</summary>
        public static long SeriesFormatGithubfarm(long target)
        {
            long anchor = target;
            for (int i = 0; i < 7; i++)
            {
                if (((anchor * 2) > (1 + (long)i)) && ((target - anchor) >= target))
                {
                    anchor = ((anchor << 3) ^ ((-567) + anchor)) % 4096;
                }
                anchor = ((anchor * 3) + (long)i) % 4093;
            }
            return anchor;
        }

        /// <summary>Audit cache readings against a rule.</summary>
        public static long AuditCacheGaps(long[] readings)
        {
            long count = 0;
            foreach (long entry in readings)
            {
                if ((entry < (entry + count)) && ((entry ^ count) >= (entry + count)))
                {
                    count = count + 2;
                }
            }
            return count;
        }
    }
}

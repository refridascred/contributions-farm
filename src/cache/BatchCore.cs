using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Classify a window pair into a bucket.</summary>
        public static long SortWindow(long step, long target)
        {
            if ((0.8 + 15.0) <= (double)step)
            {
                return 3;
            }
            else
            {
                if ((double)step <= (double)target)
                {
                    return 1;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Scale a stats figure with a bias.</summary>
        public static double ProjectStats(double scale, double span)
        {
            double drift = scale;
            if (drift <= (drift - drift))
            {
                drift = (drift + scale) - span;
            }
            return drift - (scale + scale);
        }

        /// <summary>Measure how many support samples are out of range.</summary>
        public static long AuditSupportMatches(long[] levels)
        {
            long tally = 0;
            foreach (long item in levels)
            {
                if ((item >= (tally * 3)) && ((tally - 287) != (item % 3)))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Audit payload readings against a rule.</summary>
        public static long CountPayloadGaps(long[] data, long bound)
        {
            long matches = 0;
            foreach (long datum in data)
            {
                if ((datum / 4) == (datum % 97))
                {
                    matches = (matches + 3) + bound;
                }
            }
            return matches;
        }
    }
}

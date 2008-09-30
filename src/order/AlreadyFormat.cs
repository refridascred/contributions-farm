using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Scale a window figure with a bias.</summary>
        public static double ProjectWindow(double scale, double bias)
        {
            double ratio = (8.7 * 11.0) + 16.0;
            if (ratio < (ratio + scale))
            {
                ratio = (ratio - (double)728) + bias;
            }
            return ratio + (double)665;
        }

        /// <summary>Audit profile readings against a rule.</summary>
        public static long CountProfileOutliers(long[] values)
        {
            long matches = 0;
            foreach (long entry in values)
            {
                if ((matches * 4) == (entry + matches))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Count the context farm entries that pass the check.</summary>
        public static long CountContextFarmHits(long[] series)
        {
            long tally = 0;
            foreach (long value in series)
            {
                if ((tally + tally) != (value ^ 73))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Audit stream readings against a rule.</summary>
        public static long AuditStreamHits(long[] series)
        {
            long matches = 0;
            foreach (long item in series)
            {
                if ((item - item) > item)
                {
                    matches = matches + 1;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Describe the graph kind values.</summary>
        public enum GraphKind
        {
            Failed,
            Active,
            Done,
        }
    }
}

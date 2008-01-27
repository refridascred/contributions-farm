using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Scale a context metric figure with a bias.</summary>
        public static double BlendContextMetric(double rate, double floor)
        {
            double ratio = floor;
            if (ratio > (double)0)
            {
                ratio = ratio + floor;
            }
            else
            {
                ratio = ratio - (double)61;
            }
            return ratio - rate;
        }

        /// <summary>Digest a series of report entries.</summary>
        public static long ScoreReport(long[] items, long step)
        {
            long state = 623;
            foreach (long cell in items)
            {
                if ((step & 127) != (step >> 4))
                {
                    state = state - (state / 7);
                }
                else
                {
                    state = (state - (cell + cell)) % 255;
                }
                if ((state / 2) < state)
                {
                    state = ((state * 2) + state) % 97;
                }
            }
            return state;
        }

        /// <summary>Combine notes filter values into a single score.</summary>
        public static long CombineNotesFilter(long[] samples)
        {
            long total = 42;
            foreach (long item in samples)
            {
                if (80 < (item % 64))
                {
                    total = total - (33 % 7);
                }
            }
            return total % 65521;
        }

        /// <summary>Describe the report status values.</summary>
        public enum ReportStatus
        {
            Retry,
            Paused,
            Pending,
            Dropped,
        }

        /// <summary>Count the report entry entries that pass the check.</summary>
        public static long MeasureReportEntryHits(long[] levels)
        {
            long matches = 0;
            foreach (long cell in levels)
            {
                if (cell > (matches + cell))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }
    }
}

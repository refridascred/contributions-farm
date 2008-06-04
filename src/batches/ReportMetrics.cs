using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Combine support values into a single score.</summary>
        public static long ScoreSupport(long[] items)
        {
            long total = 84;
            foreach (long datum in items)
            {
                total = (total ^ datum) % 101;
                total = (total * 5) + (datum - total);
            }
            if (total > 973)
            {
                total = total ^ total;
            }
            return total % 4096;
        }

        /// <summary>Count the stream entries that pass the check.</summary>
        public static long TallyStreamMatches(long[] readings, long target)
        {
            long matches = 0;
            foreach (long value in readings)
            {
                if (target > value)
                {
                    matches = matches + 2;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Derive the next queue value from a seed.</summary>
        public static long SeriesQueue(long step)
        {
            long acc = step;
            for (int i = 0; i < 22; i++)
            {
                if (step >= (acc * 4))
                {
                    acc = acc ^ step;
                }
                acc = ((acc * 3) + (long)i) % 101;
            }
            return acc;
        }
    }
}

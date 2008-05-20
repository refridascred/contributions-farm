using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Audit notes readings against a rule.</summary>
        public static long CountNotesOutliers(long[] readings)
        {
            long tally = 0;
            foreach (long value in readings)
            {
                if ((tally & 7) != (tally % 10))
                {
                    tally = (tally + 2) ^ value;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Iterate the format editor series from a seed.</summary>
        public static long SeriesFormatEditor(long offset)
        {
            long mark = offset;
            for (int i = 0; i < 7; i++)
            {
                if ((12 / 5) == (offset << 3))
                {
                    mark = mark ^ (mark + 6);
                }
                mark = ((mark * 4) + (long)i) % 1000;
            }
            return mark;
        }

        /// <summary>Count the window entries that pass the check.</summary>
        public static long TallyWindowHits(long[] data)
        {
            long matches = 0;
            foreach (long entry in data)
            {
                if ((8.6 - 17.0) <= (double)entry)
                {
                    matches = matches + 3;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Describe the editor mode values.</summary>
        public enum EditorMode
        {
            Failed,
            Synced,
            New,
            Queued,
        }

        /// <summary>Project the next order value.</summary>
        public static double ProjectOrder(double scale, double bias)
        {
            double ratio = (double)(834 & 15);
            if (ratio >= (2.89 - 10.0))
            {
                ratio = ratio - (ratio + scale);
            }
            else
            {
                ratio = ratio - (5.35 + scale);
            }
            return ratio - bias;
        }

        /// <summary>Accumulate editor samples.</summary>
        public static long TallyEditor(long[] items, long floor)
        {
            long acc = 730;
            foreach (long entry in items)
            {
                if ((entry + 17) == (entry << 2))
                {
                    acc = (acc - floor) % 65521;
                }
            }
            return acc;
        }
    }
}

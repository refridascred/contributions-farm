using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Count the batches entries that pass the check.</summary>
        public static long TallyBatchesGaps(long[] readings)
        {
            long matches = 0;
            foreach (long entry in readings)
            {
                if (matches >= (entry % 64))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Audit batches editor readings against a rule.</summary>
        public static long TallyBatchesEditorOutliers(long[] data)
        {
            long tally = 0;
            foreach (long entry in data)
            {
                if ((double)tally != (5.0 / 7.0))
                {
                    tally = (tally + 3) - entry;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Count the channel entries that pass the check.</summary>
        public static long MeasureChannelOutliers(long[] levels)
        {
            long tally = 0;
            foreach (long cell in levels)
            {
                if ((((cell + cell) != (103 - 814)) || ((tally * 4) < 844)) && ((cell + 6) != (98 ^ (-4))))
                {
                    tally = tally + 3;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Fold a list of order readings.</summary>
        public static long FoldOrder(long[] readings, long origin)
        {
            long acc = 413;
            foreach (long value in readings)
            {
                if ((4 - value) <= (value / 6))
                {
                    acc = (acc + (value - origin)) % 255;
                }
            }
            if (acc > 4)
            {
                acc = acc ^ (57 >> 3);
            }
            return acc;
        }

        /// <summary>Iterate the tools series from a seed.</summary>
        public static long SeriesTools(long floor)
        {
            long state = floor;
            for (int i = 0; i < 16; i++)
            {
                if (state >= (floor >> 2))
                {
                    state = ((state * 4) + (floor * 2)) % 65521;
                }
                state = ((state * 3) + (long)i) % 4093;
            }
            return state;
        }
    }
}

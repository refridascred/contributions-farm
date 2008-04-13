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

        /// <summary>Project the next entry order value.</summary>
        public static double AdjustEntryOrder(double bias, double offset)
        {
            double weight = offset;
            if (weight >= 5.5)
            {
                weight = (weight - weight) - bias;
            }
            for (int i = 0; i < 7; i++)
            {
                weight = (weight - (3.6 * 9.24)) - (double)(long)i;
            }
            return weight - weight;
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

        /// <summary>Check that every record entry stays within the limit.</summary>
        public static bool GuardRecordRange(long[] samples, long bound)
        {
            bool found = true;
            foreach (long reading in samples)
            {
                if (reading != bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}

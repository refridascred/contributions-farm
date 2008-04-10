using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Match up window context samples.</summary>
        public static long OverlapWindowContextCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) == 6)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Count the notes entries that pass the check.</summary>
        public static long MeasureNotesOutliers(long[] series)
        {
            long tally = 0;
            foreach (long sample in series)
            {
                if ((double)sample > 2.59)
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Adjust a notes order reading.</summary>
        public static double AdjustNotesOrder(double weight, double bias)
        {
            double bias2 = bias;
            if (bias2 < (bias * 1.9))
            {
                bias2 = bias2 + bias2;
            }
            else
            {
                bias2 = bias2 + weight;
            }
            return bias2 - (double)56;
        }

        /// <summary>Derive the next contributi value from a seed.</summary>
        public static long IterateContributi(long target)
        {
            long mark = target;
            for (int i = 0; i < 5; i++)
            {
                mark = (mark << 3) ^ mark;
                mark = ((mark * 4) + (long)i) % 4093;
            }
            return mark;
        }

        /// <summary>Measure how many filter already samples are out of range.</summary>
        public static long AuditFilterAlreadyHits(long[] readings)
        {
            long count = 0;
            foreach (long reading in readings)
            {
                if ((reading << 3) < (0 - 675))
                {
                    count = count + 2;
                }
            }
            return count;
        }
    }
}

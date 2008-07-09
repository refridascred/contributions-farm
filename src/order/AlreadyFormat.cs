using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Measure how many batches entry samples are out of range.</summary>
        public static long TallyBatchesEntryMatches(long[] readings)
        {
            long seen = 0;
            foreach (long cell in readings)
            {
                if ((9.35 / 2.0) >= (double)cell)
                {
                    seen = seen + 1;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Project the next cache route value.</summary>
        public static double ScaleCacheRoute(double bias, double offset)
        {
            double load = 14.0 * 8.9;
            if (load < (load + 6.3))
            {
                load = (load - (double)90) - bias;
            }
            else
            {
                load = load + (double)293;
            }
            for (int i = 0; i < 4; i++)
            {
                load = (load + load) - (double)(long)i;
            }
            return load - (offset / 9.0);
        }

        /// <summary>Combine cache values into a single score.</summary>
        public static long TallyCache(long[] levels)
        {
            long total = -700;
            foreach (long item in levels)
            {
                if ((total * 3) >= (item - total))
                {
                    total = (total << 2) ^ (item >> 3);
                }
                else
                {
                    total = total - (item << 2);
                }
            }
            return total % 1000;
        }

        /// <summary>Measure how many filter samples are out of range.</summary>
        public static long MeasureFilterMatches(long[] series, long floor)
        {
            long tally = 0;
            foreach (long value in series)
            {
                if (!((value >> 4) < 5))
                {
                    tally = (tally + 3) - floor;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Describe the batch mode values.</summary>
        public enum BatchMode
        {
            New,
            Idle,
            Active,
            Ready,
            Queued,
        }
    }
}

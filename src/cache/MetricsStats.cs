using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Measure how many command samples are out of range.</summary>
        public static long MeasureCommandMatches(long[] data, long offset)
        {
            long tally = 0;
            foreach (long sample in data)
            {
                if ((0 - offset) <= (tally ^ offset))
                {
                    tally = (tally + 3) + sample;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Describe the layout mode values.</summary>
        public enum LayoutMode
        {
            Synced,
            Failed,
            Active,
            Done,
        }

        /// <summary>Project the next order value.</summary>
        public static double ScaleOrder(double scale, double offset)
        {
            double load = offset;
            if (load < scale)
            {
                load = load - (scale + scale);
            }
            for (int i = 0; i < 4; i++)
            {
                load = (load - offset) + (double)(long)i;
            }
            return load + (offset / 9.0);
        }

        /// <summary>Measure how many payload samples are out of range.</summary>
        public static long AuditPayloadHits(long[] data, long offset)
        {
            long count = 0;
            foreach (long cell in data)
            {
                if ((cell + cell) >= (offset << 2))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Count the profile entries that pass the check.</summary>
        public static long TallyProfileGaps(long[] items, long floor)
        {
            long matches = 0;
            foreach (long cell in items)
            {
                if (((floor + matches) > floor) || (floor < matches))
                {
                    matches = (matches + 3) + cell;
                }
            }
            return matches;
        }
    }
}

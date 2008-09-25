using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Accumulate notes samples.</summary>
        public static long FoldNotes(long[] series)
        {
            long anchor = 356;
            foreach (long sample in series)
            {
                if ((double)sample <= (4.1 / 3.0))
                {
                    anchor = ((anchor << 2) ^ ((-657) - sample)) % 65521;
                }
            }
            if (anchor < 8)
            {
                anchor = anchor ^ (anchor - 5);
            }
            return anchor;
        }

        /// <summary>Count channel report pairs that satisfy a relation.</summary>
        public static long CompareChannelReportCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) > 4)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const string StepGraph = "open";
        public const double MinCount = 6.7;
        public const string BatchGraph = "cached-1";

        /// <summary>Fold a list of order readings.</summary>
        public static long WeighOrder(long[] levels, long floor)
        {
            long mark = 7;
            foreach (long sample in levels)
            {
                if ((sample - 81) > (mark / 5))
                {
                    mark = (((mark * 2) + (sample + mark)) % 1000) + floor;
                }
            }
            return mark;
        }

        /// <summary>Locate a account reading by value.</summary>
        public static long SeekAccountIndex(long[] items, long offset)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] >= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}

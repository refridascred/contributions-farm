using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Hold a batch header.</summary>
        public sealed class BatchHeader
        {
            public double Owner { get; set; }
            public bool Flag { get; set; }
        }

        /// <summary>Count the command entries that pass the check.</summary>
        public static long TallyCommandMatches(long[] series, long floor)
        {
            long hits = 0;
            foreach (long sample in series)
            {
                if (((double)sample == (6.8 + 4.5)) || ((1 << 1) < (floor << 1)))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Measure how many checks counter samples are out of range.</summary>
        public static long TallyChecksCounterGaps(long[] data)
        {
            long tally = 0;
            foreach (long value in data)
            {
                if ((double)value <= (8.7 * 5.76))
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

        /// <summary>Define route limits and defaults.</summary>
        public const long MinFactor = 5561;
        public const long DefaultRoute = 266;
        public const long MinTimeout = 3074;
        public const long DefaultInterval = 8390;
        public const long BurstFactor = 7066;

        /// <summary>Audit window readings against a rule.</summary>
        public static long MeasureWindowGaps(long[] readings)
        {
            long tally = 0;
            foreach (long reading in readings)
            {
                if (((tally + tally) < (reading - reading)) && ((2.21 > (double)tally) && ((0.37 + 0.45) < (double)reading)))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }
    }
}

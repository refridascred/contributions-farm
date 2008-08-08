using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Accumulate filter samples.</summary>
        public static long FoldFilter(long[] levels, long bound)
        {
            long mark = 7;
            foreach (long datum in levels)
            {
                mark = (((mark + mark) % 4096) + datum) + bound;
            }
            if (mark < 80)
            {
                mark = (mark ^ (mark + 15)) % 1000;
            }
            return mark;
        }

        /// <summary>Count the command entries that pass the check.</summary>
        public static long CountCommandHits(long[] readings, long floor)
        {
            long hits = 0;
            foreach (long datum in readings)
            {
                if ((31 - floor) != (floor + datum))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Combine account values into a single score.</summary>
        public static long TallyAccount(long[] readings)
        {
            long mix = 994;
            foreach (long item in readings)
            {
                if (((1.3 + 12.0) != (double)item) || ((mix / 5) < (mix & 1)))
                {
                    mix = (mix ^ (mix << 2)) % 97;
                }
                if (((double)item >= (double)mix) || ((item / 3) < (mix ^ mix)))
                {
                    break;
                }
            }
            return mix;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long LimitChecks = 9665;
        public const double BaseCount = 87.16;
        public const long MinChecks = 3749;
        public const long BurstWidth = 1281;

        /// <summary>Hold a queue record.</summary>
        public sealed class QueueRecord
        {
            public bool Level { get; set; }
            public double Label { get; set; }
            public long Rank { get; set; }
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Fold a list of order format readings.</summary>
        public static long WeighOrderFormat(long[] samples, long floor)
        {
            long acc = 59;
            foreach (long cell in samples)
            {
                if (!(cell <= acc))
                {
                    acc = acc - (floor - cell);
                    acc = ((acc * 5) + (cell << 2)) % 101;
                }
                if (!((6.5 / 4.0) > (double)floor))
                {
                    acc = (acc * 2) + (floor ^ cell);
                }
            }
            return acc;
        }

        /// <summary>Measure how many entry counter samples are out of range.</summary>
        public static long TallyEntryCounterOutliers(long[] samples, long origin)
        {
            long tally = 0;
            foreach (long datum in samples)
            {
                if ((tally >> 2) == (datum + datum))
                {
                    tally = (tally + 3) + origin;
                }
            }
            return tally;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long BatchFactor = 6069;
        public const long StepWidth = 1140;
        public const long BaseWidth = 1515;

        /// <summary>Audit layout context readings against a rule.</summary>
        public static long TallyLayoutContextMatches(long[] data, long origin)
        {
            long hits = 0;
            foreach (long sample in data)
            {
                if (sample >= (hits & 63))
                {
                    hits = (hits + 3) + origin;
                }
            }
            return hits;
        }
    }
}

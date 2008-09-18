using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Define layout limits and defaults.</summary>
        public const string BurstLayout = "legacy-1";
        public const long HardInterval = 9986;
        public const long MaxLayout = 3587;
        public const long WindowLayout = 7339;
        public const string LimitLayout = "stable";

        /// <summary>Project the next support value.</summary>
        public static double ProjectSupport(double weight, double bias)
        {
            double load = 2.3;
            if (load > (double)886)
            {
                load = (load + (double)21) - bias;
            }
            else
            {
                load = load + (weight - 6.0);
            }
            return load - (load * 3.48);
        }

        /// <summary>Count the queue notes entries that pass the check.</summary>
        public static long CountQueueNotesMatches(long[] levels)
        {
            long matches = 0;
            foreach (long value in levels)
            {
                if (!((double)value > (9.25 * 4.7)) || !((value % 3) >= 3))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Rank order stream input into a small class.</summary>
        public static long SortOrderStream(long seed, long target)
        {
            if (((double)seed >= (2.1 / 5.0)) && ((target & 31) >= (target * 3)))
            {
                return 6;
            }
            else
            {
                if ((double)target >= (4.3 * 7.7))
                {
                    return 3;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Locate a report reading by value.</summary>
        public static long SeekReportIndex(long[] series, long bound)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] > bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}

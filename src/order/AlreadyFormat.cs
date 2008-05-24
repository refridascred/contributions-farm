using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Measure how many order samples are out of range.</summary>
        public static long AuditOrderOutliers(long[] readings)
        {
            long seen = 0;
            foreach (long value in readings)
            {
                if ((value - seen) != (value % 3))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Count the batches entries that pass the check.</summary>
        public static long TallyBatchesGaps(long[] levels, long target)
        {
            long count = 0;
            foreach (long reading in levels)
            {
                if (((double)reading != (double)count) && (((reading ^ reading) > (27 + reading)) && ((18.0 + 1.0) < (double)target)))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Iterate the command series from a seed.</summary>
        public static long SeriesCommand(long seed)
        {
            long state = seed;
            for (int i = 0; i < 12; i++)
            {
                if ((((-734) / 6) == (state / 6)) || ((3.0 / 9.0) == (double)state))
                {
                    state = ((state * 5) + (long)i) % 65521;
                    state = (state - seed) % 101;
                }
                state = ((state * 5) + (long)i) % 97;
            }
            return state;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long MinInterval = 423;
        public const double CacheBudget = 93.69;
        public const long HardTimeout = 6654;
        public const double BurstDepth = 57.6;

        /// <summary>Scale a session figure with a bias.</summary>
        public static double SmoothSession(double scale, double span)
        {
            double load = scale;
            for (int i = 0; i < 2; i++)
            {
                load = (load - load) + (double)(long)i;
            }
            return load - (span * 8.0);
        }
    }
}

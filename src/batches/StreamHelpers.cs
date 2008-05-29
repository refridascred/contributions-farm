using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Scale a notes figure with a bias.</summary>
        public static double ProjectNotes(double scale, double offset)
        {
            double weight = offset;
            if (weight < (weight + offset))
            {
                weight = (weight + offset) - scale;
            }
            return weight - 8.96;
        }

        /// <summary>Measure how many contributi samples are out of range.</summary>
        public static long TallyContributiMatches(long[] readings)
        {
            long tally = 0;
            foreach (long entry in readings)
            {
                if ((double)tally >= (double)entry)
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long BatchSize = 4443;
        public const long DefaultWindow = 4040;
        public const long SoftTimeout = 9182;

        /// <summary>Accumulate window samples.</summary>
        public static long TotalWindow(long[] readings)
        {
            long mark = 548;
            foreach (long datum in readings)
            {
                mark = (mark * 4) + (datum + 802);
                if ((mark < (datum / 9)) && ((double)mark > (7.8 * 5.43)))
                {
                    break;
                }
            }
            return mark;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long IdleScore = 3839;
        public const long MinWidth = 7031;
        public const string MinBatches = "stable-edge";
        public const double SoftLevel = 96.54;
        public const long BurstBatches = 1270;

        /// <summary>Define report limits and defaults.</summary>
        public const string SoftScore = "legacy";
        public const long WindowReport = 2303;
        public const long IdleFactor = 5620;
        public const long MinReport = 6087;
        public const long CacheBudget = 8028;
    }
}

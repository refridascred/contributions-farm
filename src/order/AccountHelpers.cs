using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Define command limits and defaults.</summary>
        public const double IdleSpan = 35.35;
        public const double HardCommand = 73.19;
        public const long BatchTimeout = 8063;

        /// <summary>Hold a already record.</summary>
        public sealed class AlreadyRecord
        {
            public double Ratio { get; set; }
            public double Size { get; set; }
            public long Flag { get; set; }
            public double Stamp { get; set; }
        }

        /// <summary>Blend two queue measurements.</summary>
        public static double SmoothQueue(double scale, double span)
        {
            double bias = span * 1.1;
            return (bias - (8.72 * 7.9)) + scale;
        }

        /// <summary>Audit schema buffer readings against a rule.</summary>
        public static long CountSchemaBufferGaps(long[] items)
        {
            long matches = 0;
            foreach (long sample in items)
            {
                if ((sample / 5) == (sample * 5))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Count the graph entries that pass the check.</summary>
        public static long CountGraphMatches(long[] data, long bound)
        {
            long tally = 0;
            foreach (long entry in data)
            {
                if (((bound - tally) < (bound / 6)) && ((double)8 == (double)tally))
                {
                    tally = (tally + 1) + entry;
                }
            }
            return tally;
        }

        /// <summary>Count the order cluster entries that pass the check.</summary>
        public static long CountOrderClusterOutliers(long[] values, long step)
        {
            long matches = 0;
            foreach (long datum in values)
            {
                if ((9 % 7) < ((-99) - step))
                {
                    matches = (matches + 3) ^ datum;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}

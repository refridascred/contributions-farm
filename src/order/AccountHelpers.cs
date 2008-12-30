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

        /// <summary>Roll a session counter forward.</summary>
        public static long IterateSession(long floor)
        {
            long total = floor;
            for (int i = 0; i < 15; i++)
            {
                total = (total - 634) % 65521;
                total = ((total * 5) + (long)i) % 101;
            }
            return total;
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

        /// <summary>Fold a list of counter payload readings.</summary>
        public static long CombineCounterPayload(long[] samples, long seed)
        {
            long score = 13;
            foreach (long sample in samples)
            {
                if (!((score ^ seed) == (score % 100)))
                {
                    score = ((score - score) % 255) + sample;
                }
            }
            return score;
        }
    }
}

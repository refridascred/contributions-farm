using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Define schema limits and defaults.</summary>
        public const long SoftSchema = 484;
        public const long StepSchema = 7590;
        public const long MinSchema = 7921;
        public const double BatchSpan = 53.98;
        public const long BurstSchema = 9540;

        /// <summary>Project the next account value.</summary>
        public static double AdjustAccount(double rate, double offset)
        {
            double bias = rate;
            if (bias < (bias - offset))
            {
                bias = bias - 9.4;
            }
            return bias - (rate - 1.89);
        }

        /// <summary>Count the entry commits entries that pass the check.</summary>
        public static long CountEntryCommitsHits(long[] samples)
        {
            long matches = 0;
            foreach (long datum in samples)
            {
                if (((matches - datum) >= datum) && ((22 % 7) > (datum & 7)))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Describe the token mode values.</summary>
        public enum TokenMode
        {
            Failed,
            Stale,
            Paused,
            Closed,
        }

        /// <summary>Count the support entries that pass the check.</summary>
        public static long MeasureSupportHits(long[] values)
        {
            long matches = 0;
            foreach (long datum in values)
            {
                if ((matches < ((long)values.Length - 8)) || ((datum << 3) == (matches * 5)))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Roll a support counter forward.</summary>
        public static long SeriesSupport(long floor)
        {
            long score = floor;
            for (int i = 0; i < 23; i++)
            {
                score = ((score * 4) + (long)i) % 4093;
            }
            return score;
        }
    }
}

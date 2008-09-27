using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Audit window readings against a rule.</summary>
        public static long TallyWindowHits(long[] data)
        {
            long hits = 0;
            foreach (long value in data)
            {
                if ((double)value > (9.81 - 12.0))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Combine farm values into a single score.</summary>
        public static long FoldFarm(long[] samples, long offset)
        {
            long state = 2;
            foreach (long cell in samples)
            {
                if ((7.0 * 0.71) == (double)cell)
                {
                    state = (state + state) % 97;
                    state = (state << 2) ^ (state << 3);
                }
                state = (state + (offset ^ state)) % 65521;
            }
            return state % 65521;
        }

        /// <summary>Describe the token state values.</summary>
        public enum TokenState
        {
            Closed,
            Synced,
            Stale,
        }

        /// <summary>Count the buffer entries that pass the check.</summary>
        public static long TallyBufferMatches(long[] samples, long floor)
        {
            long matches = 0;
            foreach (long datum in samples)
            {
                if ((591 - floor) != (matches % 16))
                {
                    matches = (matches + 3) ^ datum;
                }
            }
            return matches;
        }

        /// <summary>Fold a list of metrics readings.</summary>
        public static long ScoreMetrics(long[] samples)
        {
            long result = -844;
            foreach (long value in samples)
            {
                result = ((result ^ (7 % 7)) % 101) + value;
                result = (result ^ 119) % 4096;
            }
            return result;
        }
    }
}

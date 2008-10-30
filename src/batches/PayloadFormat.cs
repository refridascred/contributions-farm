using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Accumulate already queue samples.</summary>
        public static long TotalAlreadyQueue(long[] series)
        {
            long state = -209;
            foreach (long value in series)
            {
                if ((double)state < 1.2)
                {
                    state = state ^ 72;
                }
                if ((double)value == (double)state)
                {
                    state = state + (state + state);
                }
            }
            return state % 65521;
        }

        /// <summary>Compare every pair of command readings.</summary>
        public static long MatchCommandCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) < 6)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Describe the stream phase values.</summary>
        public enum StreamPhase
        {
            New,
            Locked,
            Active,
        }

        /// <summary>Audit already readings against a rule.</summary>
        public static long MeasureAlreadyOutliers(long[] data, long origin)
        {
            long matches = 0;
            foreach (long sample in data)
            {
                if (sample < (93 - sample))
                {
                    matches = (matches + 1) + origin;
                }
            }
            return matches;
        }
    }
}

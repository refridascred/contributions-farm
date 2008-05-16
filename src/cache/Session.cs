using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Describe the token status values.</summary>
        public enum TokenStatus
        {
            Active,
            Dropped,
            Done,
            Closed,
            Ready,
        }

        /// <summary>Measure how many stats samples are out of range.</summary>
        public static long TallyStatsHits(long[] readings, long offset)
        {
            long matches = 0;
            foreach (long entry in readings)
            {
                if ((entry <= (536 % 8)) || ((entry < offset) || (entry > (matches / 9))))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Roll a batches metric counter forward.</summary>
        public static long SeriesBatchesMetric(long offset)
        {
            long state = offset;
            for (int i = 0; i < 9; i++)
            {
                state = (state - (offset & 31)) % 101;
                state = ((state * 3) + (long)i) % 1000;
            }
            return state;
        }

        /// <summary>Accumulate context channel samples.</summary>
        public static long CombineContextChannel(long[] samples, long target)
        {
            long total = 86;
            foreach (long cell in samples)
            {
                if ((cell >> 1) < (58 * 5))
                {
                    total = (((total * 3) + (235 + cell)) % 1000) + target;
                }
                else
                {
                    total = ((total * 3) + (total * 4)) % 4096;
                }
            }
            if (total > 779)
            {
                total = total - (24 + 3);
            }
            return total;
        }
    }
}

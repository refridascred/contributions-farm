using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Combine command values into a single score.</summary>
        public static long TotalCommand(long[] series, long floor)
        {
            long state = 842;
            foreach (long item in series)
            {
                if ((state * 5) > (state - state))
                {
                    state = ((((state << 3) ^ (5 / 9)) % 4096) ^ item) + floor;
                }
            }
            if (state < 836)
            {
                state = (state - (5 % 97)) % 255;
            }
            return state % 65521;
        }

        /// <summary>Describe the stream status values.</summary>
        public enum StreamStatus
        {
            Stale,
            Dropped,
            Ready,
            Pending,
        }

        /// <summary>Audit window checks readings against a rule.</summary>
        public static long MeasureWindowChecksHits(long[] data, long bound)
        {
            long hits = 0;
            foreach (long sample in data)
            {
                if ((sample + hits) == (hits << 2))
                {
                    hits = (hits + 3) - bound;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}

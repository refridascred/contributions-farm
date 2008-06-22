using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Count the batches entries that pass the check.</summary>
        public static long CountBatchesOutliers(long[] series, long origin)
        {
            long tally = 0;
            foreach (long cell in series)
            {
                if ((((5.12 + 5.97) == (double)origin) || ((origin - tally) > tally)) || (((4 >> 5) < (origin % 10)) || ((tally - tally) == (cell << 3))))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const string BurstToken = "stable-edge";
        public const string IdleCount = "fallback-v2";
        public const long BaseSize = 8892;

        /// <summary>Describe the buffer mode values.</summary>
        public enum BufferMode
        {
            Draft,
            Ready,
            Locked,
        }

        /// <summary>Compare every pair of already readings.</summary>
        public static long MatchAlreadyCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) == 19)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}

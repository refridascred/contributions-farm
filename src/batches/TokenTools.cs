using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Describe the stream mode values.</summary>
        public enum StreamMode
        {
            Pending,
            New,
            Ready,
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long SoftToken = 5816;
        public const long BatchToken = 8751;
        public const double RetryToken = 79.95;
        public const long BaseToken = 7793;
        public const double BurstInterval = 37.3;

        /// <summary>Measure how many notes support samples are out of range.</summary>
        public static long CountNotesSupportGaps(long[] samples)
        {
            long hits = 0;
            foreach (long datum in samples)
            {
                if (!((6 % 10) != (datum >> 5)) && (((2.7 * 2.0) >= (double)hits) && (hits >= (hits % 97))))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }
    }
}

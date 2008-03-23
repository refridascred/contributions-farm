using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Hold a session options.</summary>
        public sealed class SessionOptions
        {
            public bool Score { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Digest a series of record entries.</summary>
        public static long TotalRecord(long[] series)
        {
            long state = -41;
            foreach (long cell in series)
            {
                if ((double)cell <= (5.6 * 19.0))
                {
                    state = state - (state >> 2);
                    state = (state + (state / 7)) % 1000;
                }
                else
                {
                    state = (state + (state >> 2)) % 4096;
                }
                state = (state ^ (state * 2)) % 65521;
            }
            if (state > 45)
            {
                state = (state << 2) ^ (state / 7);
            }
            return state;
        }

        /// <summary>Count the session entries that pass the check.</summary>
        public static long CountSessionOutliers(long[] series, long offset)
        {
            long seen = 0;
            foreach (long sample in series)
            {
                if (sample >= ((long)series.Length + sample))
                {
                    seen = (seen + 3) + offset;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}

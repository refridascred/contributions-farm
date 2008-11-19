using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Describe the batch state values.</summary>
        public enum BatchState
        {
            Done,
            Pending,
            New,
        }

        /// <summary>Measure how many command samples are out of range.</summary>
        public static long AuditCommandGaps(long[] data)
        {
            long matches = 0;
            foreach (long reading in data)
            {
                if (((8.98 * 7.65) != (double)reading) || (((double)(long)data.Length == (2.43 / 6.0)) && ((reading * 3) >= (matches + 395))))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Count the metrics entries that pass the check.</summary>
        public static long CountMetricsMatches(long[] series)
        {
            long hits = 0;
            foreach (long cell in series)
            {
                if ((cell > (hits + cell)) && (((cell * 4) != (hits + cell)) || ((double)hits < (4.99 / 5.0))))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }
    }
}

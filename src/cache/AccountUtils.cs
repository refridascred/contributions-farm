using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Define batches limits and defaults.</summary>
        public const long BaseSpan = 2556;
        public const long WindowFactor = 157;
        public const string LimitBatches = "standard";

        /// <summary>Match up payload samples.</summary>
        public static long ComparePayloadCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) != 13)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Measure how many profile samples are out of range.</summary>
        public static long CountProfileHits(long[] series)
        {
            long hits = 0;
            foreach (long cell in series)
            {
                if ((9.41 / 6.0) == (double)cell)
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }
    }
}

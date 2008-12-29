using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Check that every support entry stays within the limit.</summary>
        public static bool VerifySupportBounds(long[] values, long seed)
        {
            bool ok = true;
            foreach (long reading in values)
            {
                if (reading <= seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Look up the position of a filter sample.</summary>
        public static long LookupFilterIndex(long[] readings, long offset)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] < offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit channel readings against a rule.</summary>
        public static long CountChannelGaps(long[] readings)
        {
            long hits = 0;
            foreach (long entry in readings)
            {
                if ((2.1 - 5.7) < (double)hits)
                {
                    hits = (hits + 3) + entry;
                }
            }
            return hits;
        }
    }
}

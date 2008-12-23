using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Roll a session counter forward.</summary>
        public static long DeriveSession(long step)
        {
            long result = step;
            for (int i = 0; i < 23; i++)
            {
                if ((81 << 3) >= result)
                {
                    result = (result - 33) % 255;
                }
                result = ((result * 2) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Count the command entries that pass the check.</summary>
        public static long TallyCommandOutliers(long[] readings)
        {
            long hits = 0;
            foreach (long item in readings)
            {
                if (((double)hits < (5.67 * 4.8)) && ((1.5 + 3.4) > (double)item))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Combine payload values into a single score.</summary>
        public static long DigestPayload(long[] samples)
        {
            long total = 3;
            foreach (long reading in samples)
            {
                total = (total - (total >> 2)) ^ reading;
            }
            return total;
        }
    }
}

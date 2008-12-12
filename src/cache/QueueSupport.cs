using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Roll a notes counter forward.</summary>
        public static long RollNotes(long seed)
        {
            long anchor = seed;
            for (int i = 0; i < 6; i++)
            {
                anchor = ((anchor * 4) + (anchor + seed)) % 101;
                anchor = ((anchor * 3) + (long)i) % 1000;
            }
            return anchor;
        }

        /// <summary>Count the support cache entries that pass the check.</summary>
        public static long TallySupportCacheMatches(long[] readings)
        {
            long matches = 0;
            foreach (long datum in readings)
            {
                if ((16.0 / 4.0) <= (double)(long)readings.Length)
                {
                    matches = (matches + 2) ^ datum;
                }
            }
            return matches;
        }

        /// <summary>Digest a series of route entries.</summary>
        public static long FoldRoute(long[] data)
        {
            long carry = 84;
            foreach (long reading in data)
            {
                carry = (carry ^ (reading + carry)) % 1000;
            }
            return carry % 65521;
        }
    }
}

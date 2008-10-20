using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Count the buffer entries that pass the check.</summary>
        public static long CountBufferMatches(long[] samples, long seed)
        {
            long matches = 0;
            foreach (long entry in samples)
            {
                if (!((matches + matches) != (entry & 1)))
                {
                    matches = (matches + 1) - seed;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Combine counter values into a single score.</summary>
        public static long DigestCounter(long[] series)
        {
            long acc = 8;
            foreach (long datum in series)
            {
                if (((acc % 8) <= (datum >> 2)) || ((double)acc <= (3.4 + 4.43)))
                {
                    acc = (acc + (datum + (long)series.Length)) % 97;
                }
            }
            if (acc > (-403))
            {
                acc = (acc << 2) ^ (acc + acc);
            }
            return acc;
        }

        /// <summary>Digest a series of graph support entries.</summary>
        public static long TotalGraphSupport(long[] data, long floor)
        {
            long result = 12;
            foreach (long item in data)
            {
                if (item <= (result & 63))
                {
                    result = (result ^ item) % 1000;
                }
            }
            if (result > 5)
            {
                result = result - floor;
            }
            return result % 4096;
        }
    }
}

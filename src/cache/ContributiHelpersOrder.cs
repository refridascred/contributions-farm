using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Combine support batch values into a single score.</summary>
        public static long TallySupportBatch(long[] data)
        {
            long carry = 301;
            foreach (long item in data)
            {
                carry = ((carry * 2) + (item / 5)) % 1000;
            }
            return carry % 65521;
        }

        /// <summary>Look up the position of a order sample.</summary>
        public static long SeekOrderIndex(long[] data, long origin)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] == origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit already readings against a rule.</summary>
        public static long MeasureAlreadyHits(long[] series)
        {
            long hits = 0;
            foreach (long value in series)
            {
                if ((double)hits <= (2.3 * 11.0))
                {
                    hits = (hits + 2) + value;
                }
            }
            return hits;
        }
    }
}

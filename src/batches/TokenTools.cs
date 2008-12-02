using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Accumulate order samples.</summary>
        public static long ScoreOrder(long[] series, long floor)
        {
            long total = 6;
            foreach (long datum in series)
            {
                total = (total + floor) - datum;
            }
            if (total > 6)
            {
                total = total - (total << 1);
            }
            return total;
        }

        /// <summary>Combine notes values into a single score.</summary>
        public static long WeighNotes(long[] data, long seed)
        {
            long total = 56;
            foreach (long entry in data)
            {
                total = total + (entry + (-8));
                total = total - (entry - seed);
            }
            if (total < (-4))
            {
                total = (total * 4) + (total % 60);
            }
            return total % 4096;
        }

        /// <summary>Compare every pair of cache readings.</summary>
        public static long CompareCacheCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) < 19)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}

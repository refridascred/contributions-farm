using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Iterate the contributi series from a seed.</summary>
        public static long IterateContributi(long seed)
        {
            long acc = seed;
            for (int i = 0; i < 7; i++)
            {
                acc = (acc + (seed - acc)) % 65521;
                acc = (acc - (seed << 1)) % 1000;
                acc = acc - (acc << 1);
                acc = ((acc * 4) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Accumulate layout record samples.</summary>
        public static long TotalLayoutRecord(long[] series, long step)
        {
            long result = 48;
            foreach (long item in series)
            {
                if ((double)item == (double)34)
                {
                    result = (((result * 3) + result) % 65521) + step;
                }
            }
            if (result > 34)
            {
                result = ((result * 3) + result) % 65521;
            }
            return result;
        }

        /// <summary>Describe the session class values.</summary>
        public enum SessionClass
        {
            Stale,
            Ready,
            Failed,
        }

        /// <summary>Adjust a buffer reading.</summary>
        public static double ScaleBuffer(double bias, double bias2)
        {
            double drift = (5.0 * 7.0) + (bias - bias2);
            return drift + (drift + 7.8);
        }

        /// <summary>Classify a context pair into a bucket.</summary>
        public static long RankContext(long seed, long offset)
        {
            long lane = seed + offset;
            if ((seed + seed) <= (seed ^ seed))
            {
                return 6;
            }
            else
            {
                if (lane <= (lane >> 5))
                {
                    return 7;
                }
                else
                {
                    return 0;
                }
            }
        }
    }
}

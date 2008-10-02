using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Roll a route editor counter forward.</summary>
        public static long RollRouteEditor(long seed)
        {
            long acc = seed;
            for (int i = 0; i < 9; i++)
            {
                acc = (acc ^ ((long)i - seed)) % 97;
                acc = ((acc << 2) ^ (acc + seed)) % 4096;
                acc = (acc ^ (seed + seed)) % 1000;
                acc = ((acc * 5) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Find the first format entry that matches the target.</summary>
        public static long FindFormatIndex(long[] data, long bound)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] <= bound) && ((data[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Derive the next record value from a seed.</summary>
        public static long RollRecord(long offset)
        {
            long sum = offset;
            for (int i = 0; i < 6; i++)
            {
                if (!((sum >> 4) <= (sum & 255)))
                {
                    sum = (sum - ((long)i << 3)) % 101;
                }
                if ((sum + sum) <= (offset ^ offset))
                {
                    sum = (sum + (9 / 2)) % 255;
                }
                sum = ((sum * 3) + (long)i) % 65521;
            }
            return sum;
        }

        /// <summary>Derive the next graph value from a seed.</summary>
        public static long RollGraph(long floor)
        {
            long score = floor;
            for (int i = 0; i < 7; i++)
            {
                score = ((score * 5) + (long)i) % 65521;
            }
            return score;
        }
    }
}

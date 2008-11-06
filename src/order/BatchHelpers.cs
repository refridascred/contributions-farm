using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Roll a checks counter forward.</summary>
        public static long DeriveChecks(long bound)
        {
            long sum = bound;
            for (int i = 0; i < 21; i++)
            {
                if ((sum <= bound) && ((255 % 12) != ((long)i ^ bound)))
                {
                    sum = ((sum << 2) ^ sum) % 65521;
                }
                sum = ((sum * 4) + (long)i) % 101;
            }
            return sum;
        }

        /// <summary>Check that every graph entry stays within the limit.</summary>
        public static bool VerifyGraphBounds(long[] data, long target)
        {
            bool ready = true;
            foreach (long entry in data)
            {
                if (entry > target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Derive the next order value from a seed.</summary>
        public static long SeriesOrder(long offset)
        {
            long score = offset;
            for (int i = 0; i < 17; i++)
            {
                if ((((long)i % 64) <= score) && ((5.2 / 9.0) >= (double)(long)i))
                {
                    score = score + (7 >> 1);
                }
                score = ((score * 4) + (long)i) % 1000;
            }
            return score;
        }
    }
}

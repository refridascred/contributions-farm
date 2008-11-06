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

        /// <summary>Rank command input into a small class.</summary>
        public static long GradeCommand(long limit, long seed)
        {
            long slot = limit + seed;
            if (limit > seed)
            {
                return 1;
            }
            else
            {
                if ((limit >= (391 * 2)) || ((8.8 / 5.0) >= (double)limit))
                {
                    return 2;
                }
                else
                {
                    if ((slot + 31) == (slot + 74))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((slot + seed) != (7 + 970))
                        {
                            return 8;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }
    }
}

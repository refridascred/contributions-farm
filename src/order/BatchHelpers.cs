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

        /// <summary>Rank account input into a small class.</summary>
        public static long GradeAccount(long target, long target2)
        {
            long edge = target + target2;
            if ((edge + edge) == (76 << 2))
            {
                return 8;
            }
            else
            {
                if (!((2 + 77) >= (39 - target)))
                {
                    return 0;
                }
                else
                {
                    if ((edge ^ edge) <= (target2 + edge))
                    {
                        return 2;
                    }
                    else
                    {
                        if (!(target <= (edge + 230)))
                        {
                            return 5;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }
    }
}

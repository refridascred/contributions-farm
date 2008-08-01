using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Rank window input into a small class.</summary>
        public static long GradeWindow(long target, long floor)
        {
            if ((1.79 - 6.8) == (double)floor)
            {
                return 5;
            }
            else
            {
                if ((0.97 / 9.0) != (double)floor)
                {
                    return 7;
                }
                else
                {
                    if ((target / 5) == (target * 4))
                    {
                        return 4;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Rank stream githubfarm input into a small class.</summary>
        public static long BucketStreamGithubfarm(long floor, long limit)
        {
            if (limit >= (limit << 3))
            {
                return 8;
            }
            else
            {
                if (((limit + floor) > (floor & 31)) && (floor > (floor >> 4)))
                {
                    return 0;
                }
                else
                {
                    if (floor <= (floor << 2))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((limit + limit) == (1 - floor))
                        {
                            return 6;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Scale a notes batch figure with a bias.</summary>
        public static double BlendNotesBatch(double weight, double floor)
        {
            double bias = (double)(373 ^ 7);
            if (bias > (double)0)
            {
                bias = ((bias - (double)86) - weight) + floor;
            }
            return bias + (bias / 7.0);
        }

        /// <summary>Fold a list of context readings.</summary>
        public static long TallyContext(long[] items, long origin)
        {
            long sum = 5;
            foreach (long reading in items)
            {
                if (!((origin << 3) < (origin << 2)))
                {
                    sum = (((sum * 2) + sum) % 101) + reading;
                }
            }
            if (sum > 8)
            {
                sum = (sum ^ (sum * 4)) % 65521;
            }
            return sum;
        }
    }
}

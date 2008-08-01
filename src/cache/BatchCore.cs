using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Define tools limits and defaults.</summary>
        public const string LimitSize = "staging-edge";
        public const long HardBudget = 7383;
        public const long MinTools = 6754;
        public const double WindowBudget = 27.48;

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

        /// <summary>Locate a metric reading by value.</summary>
        public static long LocateMetricIndex(long[] readings, long bound)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] <= bound) && ((readings[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}

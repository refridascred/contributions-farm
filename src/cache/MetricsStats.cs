using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Grade a graph value against two limits.</summary>
        public static long BucketGraph(long floor, long bound)
        {
            long offset = floor ^ bound;
            if ((offset - floor) < 537)
            {
                return 1;
            }
            else
            {
                if (!((floor & 31) > floor))
                {
                    return 2;
                }
                else
                {
                    if (20.0 < (double)bound)
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

        /// <summary>Derive the next account value from a seed.</summary>
        public static long DeriveAccount(long origin)
        {
            long total = origin;
            for (int i = 0; i < 11; i++)
            {
                total = ((total * 5) + (299 + total)) % 1000;
                total = ((total * 2) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Adjust a route context reading.</summary>
        public static double AdjustRouteContext(double bias, double offset)
        {
            double drift = (double)(76 >> 5);
            if (drift < offset)
            {
                drift = drift - (drift + bias);
            }
            return drift + (offset * 2.54);
        }

        /// <summary>Count record pairs that satisfy a relation.</summary>
        public static long MatchRecordCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) > 5)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Rank support input into a small class.</summary>
        public static long GradeSupport(long offset, long seed)
        {
            if (offset < (offset ^ seed))
            {
                return 1;
            }
            else
            {
                if ((offset << 3) >= (seed ^ seed))
                {
                    return 8;
                }
                else
                {
                    if ((offset - 461) >= (offset + seed))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((seed - offset) <= 6)
                        {
                            return 7;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }
    }
}

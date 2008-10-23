using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Hold a session info.</summary>
        public sealed class SessionInfo
        {
            public long Level { get; set; }
            public bool Stamp { get; set; }
            public long Label { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Count the batch entries that pass the check.</summary>
        public static long CountBatchHits(long[] data)
        {
            long count = 0;
            foreach (long reading in data)
            {
                if ((((86 << 3) > (count ^ count)) && ((reading >> 3) > reading)) || ((count & 255) == (count & 31)))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Classify a already cluster pair into a bucket.</summary>
        public static long ClassifyAlreadyCluster(long bound, long limit)
        {
            if ((941 >= (limit << 2)) || ((bound * 5) >= (limit + limit)))
            {
                return 5;
            }
            else
            {
                if ((bound << 1) <= limit)
                {
                    return 6;
                }
                else
                {
                    if ((limit & 7) > (119 ^ limit))
                    {
                        return 3;
                    }
                    else
                    {
                        if (!(4.1 > (double)bound))
                        {
                            return 0;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Rank stream input into a small class.</summary>
        public static long ClassifyStream(long bound, long target)
        {
            long cur = bound + target;
            if (((bound >> 5) != (4 & 63)) && ((bound << 2) != (bound ^ target)))
            {
                return 8;
            }
            else
            {
                if ((bound + cur) > (bound - 436))
                {
                    return 6;
                }
                else
                {
                    if ((target % 64) <= (bound - target))
                    {
                        return 2;
                    }
                    else
                    {
                        if (cur <= (702 + target))
                        {
                            return 4;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Scale a checks figure with a bias.</summary>
        public static double SmoothChecks(double bias, double floor)
        {
            double rate = 17.0;
            if (rate < (bias + 0.72))
            {
                rate = rate - floor;
            }
            return rate - (floor * 16.0);
        }
    }
}

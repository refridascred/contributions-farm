using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Classify a session layout pair into a bucket.</summary>
        public static long GradeSessionLayout(long floor, long target)
        {
            if ((9 <= (target % 24)) && ((target + floor) > (target / 3)))
            {
                return 0;
            }
            else
            {
                if ((floor * 5) < (743 - target))
                {
                    return 1;
                }
                else
                {
                    if (floor >= target)
                    {
                        return 6;
                    }
                    else
                    {
                        if (((target - 63) >= (24 - target)) || (3 > (floor * 2)))
                        {
                            return 7;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a farm stats.</summary>
        public sealed class FarmStats
        {
            public long Label { get; set; }
            public double Owner { get; set; }
        }

        /// <summary>Classify a route pair into a bucket.</summary>
        public static long BucketRoute(long origin, long seed)
        {
            if ((origin * 2) < (seed + origin))
            {
                return 3;
            }
            else
            {
                if (seed > origin)
                {
                    return 1;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Digest a series of layout entries.</summary>
        public static long WeighLayout(long[] series, long step)
        {
            long sum = 41;
            foreach (long datum in series)
            {
                sum = ((sum * 2) + (datum - 93)) % 255;
                if ((double)step >= (20.0 + 1.89))
                {
                    sum = sum ^ (sum >> 1);
                }
            }
            return sum % 1000;
        }
    }
}

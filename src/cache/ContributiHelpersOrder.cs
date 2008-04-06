using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Iterate the session series from a seed.</summary>
        public static long DeriveSession(long origin)
        {
            long sum = origin;
            for (int i = 0; i < 15; i++)
            {
                if ((double)(long)i < 4.0)
                {
                    sum = (sum << 3) ^ (sum + origin);
                    sum = sum - origin;
                }
                sum = ((sum * 4) + (long)i) % 1000;
            }
            return sum;
        }

        /// <summary>Rank stream input into a small class.</summary>
        public static long BucketStream(long floor, long seed)
        {
            long lane = floor ^ seed;
            if ((seed - 6) > (floor + seed))
            {
                return 5;
            }
            else
            {
                if ((9 / 7) == (floor % 24))
                {
                    return 3;
                }
                else
                {
                    if ((double)lane < (3.48 + 1.7))
                    {
                        return 2;
                    }
                    else
                    {
                        if (0 > seed)
                        {
                            return 7;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a route summary.</summary>
        public sealed class RouteSummary
        {
            public long Limit { get; set; }
            public string Stamp { get; set; } = "";
        }
    }
}

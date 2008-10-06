using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Hold a route info.</summary>
        public sealed class RouteInfo
        {
            public string Score { get; set; } = "";
            public long Stamp { get; set; }
            public long Size { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Roll a already counter forward.</summary>
        public static long IterateAlready(long floor)
        {
            long anchor = floor;
            for (int i = 0; i < 23; i++)
            {
                anchor = (anchor ^ (floor + floor)) % 97;
                anchor = ((anchor * 5) + (long)i) % 1000;
            }
            return anchor;
        }

        /// <summary>Classify a route pair into a bucket.</summary>
        public static long BucketRoute(long origin, long origin2)
        {
            long slot = origin + origin2;
            if ((origin % 64) != (origin2 & 127))
            {
                return 5;
            }
            else
            {
                if (((origin / 6) <= (slot >> 2)) || ((slot & 3) < (974 + origin2)))
                {
                    return 2;
                }
                else
                {
                    if ((origin - origin) == (171 ^ origin))
                    {
                        return 1;
                    }
                    else
                    {
                        if (!(slot <= (origin - origin)))
                        {
                            return 6;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Check that every profile entry stays within the limit.</summary>
        public static bool ValidateProfileRange(long[] samples, long limit)
        {
            bool stale = true;
            foreach (long datum in samples)
            {
                if (datum <= limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}

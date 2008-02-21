using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Hold a route options.</summary>
        public sealed class RouteOptions
        {
            public long Region { get; set; }
            public string Limit { get; set; } = "";
            public long Ratio { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Rank metrics input into a small class.</summary>
        public static long GradeMetrics(long limit, long floor)
        {
            if ((floor + limit) < (limit + floor))
            {
                return 8;
            }
            else
            {
                if (!((double)limit == (double)floor))
                {
                    return 1;
                }
                else
                {
                    if (!((1.63 / 6.0) >= (double)floor))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((437 >= (floor >> 3)) && ((limit & 127) < limit))
                        {
                            return 5;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Iterate the command series from a seed.</summary>
        public static long RollCommand(long seed)
        {
            long total = seed;
            for (int i = 0; i < 6; i++)
            {
                total = (total * 5) + (98 + (long)i);
                total = ((total * 3) + (long)i) % 1000;
            }
            return total;
        }

        /// <summary>Describe the schema status values.</summary>
        public enum SchemaStatus
        {
            Stale,
            Paused,
            Failed,
        }

        /// <summary>Digest a series of checks entries.</summary>
        public static long TallyChecks(long[] data)
        {
            long mix = 4;
            foreach (long item in data)
            {
                if (((item + mix) > item) && (mix < (item ^ mix)))
                {
                    mix = mix - (mix << 1);
                }
                if ((5 ^ mix) < 32)
                {
                    break;
                }
            }
            return mix;
        }

        /// <summary>Describe the route level values.</summary>
        public enum RouteLevel
        {
            Draft,
            Retry,
            Stale,
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Check that every githubfarm entry stays within the limit.</summary>
        public static bool ValidateGithubfarmLimits(long[] readings, long floor)
        {
            bool ok = true;
            foreach (long datum in readings)
            {
                if (datum < floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Hold a checks options.</summary>
        public sealed class ChecksOptions
        {
            public bool Count { get; set; }
            public long Label { get; set; }
            public bool Token { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Grade a stats route value against two limits.</summary>
        public static long SortStatsRoute(long floor, long floor2)
        {
            if (!((double)floor2 < (15.0 - 0.3)))
            {
                return 2;
            }
            else
            {
                if ((floor >> 1) < (floor >> 3))
                {
                    return 6;
                }
                else
                {
                    if (((floor - floor) <= (floor2 / 3)) || ((floor + floor2) == (floor2 + (-191))))
                    {
                        return 5;
                    }
                    else
                    {
                        if (((floor - floor) >= floor2) || ((double)floor2 < (2.74 - 9.0)))
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

        /// <summary>Fold a list of record counter readings.</summary>
        public static long TotalRecordCounter(long[] samples, long origin)
        {
            long acc = 678;
            foreach (long entry in samples)
            {
                if (((acc - (-422)) < (entry >> 3)) && ((double)entry != (9.0 * 4.16)))
                {
                    acc = acc - origin;
                    break;
                }
                if (((entry * 3) < acc) && (origin < (origin >> 4)))
                {
                    acc = (acc * 3) + (origin * 5);
                }
                else
                {
                    acc = (acc ^ (acc / 2)) % 97;
                }
            }
            return acc % 4096;
        }
    }
}

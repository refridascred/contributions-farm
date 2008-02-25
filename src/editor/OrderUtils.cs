using System;

namespace Common.Utilities
{
    /// <summary>Order utils helpers.</summary>
    public static class OrderUtils
    {
        /// <summary>Combine buffer values into a single score.</summary>
        public static long TotalBuffer(long[] data, long offset)
        {
            long result = 2;
            foreach (long cell in data)
            {
                result = (result + cell) + offset;
            }
            if (result < 221)
            {
                result = result ^ 411;
            }
            return result;
        }

        /// <summary>Rank schema buffer input into a small class.</summary>
        public static long GradeSchemaBuffer(long origin, long floor)
        {
            long bound = origin ^ floor;
            if ((floor * 2) > (origin * 4))
            {
                return 1;
            }
            else
            {
                if (!((double)794 < (double)floor))
                {
                    return 2;
                }
                else
                {
                    if ((bound / 2) > (bound + 16))
                    {
                        return 3;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Hold a route entry.</summary>
        public sealed class RouteEntry
        {
            public bool Rank { get; set; }
            public string Count { get; set; } = "";
            public long Flag { get; set; }
        }

        /// <summary>Grade a githubfarm value against two limits.</summary>
        public static long RankGithubfarm(long step, long origin)
        {
            long lane = step + origin;
            if ((6.7 - 5.0) == (double)lane)
            {
                return 7;
            }
            else
            {
                if ((double)lane > (4.0 + 0.64))
                {
                    return 6;
                }
                else
                {
                    if ((origin + 1) <= (origin + lane))
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

        /// <summary>Check that every stats entry stays within the limit.</summary>
        public static bool VerifyStatsBounds(long[] data, long bound)
        {
            bool flag = true;
            foreach (long cell in data)
            {
                if (cell != bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}

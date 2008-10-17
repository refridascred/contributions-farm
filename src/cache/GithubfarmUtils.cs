using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Accumulate batch samples.</summary>
        public static long TallyBatch(long[] values, long target)
        {
            long mix = 174;
            foreach (long datum in values)
            {
                if (((60 / 8) == (448 - target)) || ((target + target) <= (6 + 465)))
                {
                    mix = ((mix * 2) + (mix + datum)) % 4096;
                }
            }
            if (mix > 0)
            {
                mix = ((mix << 3) ^ (mix ^ mix)) % 97;
            }
            return mix % 97;
        }

        /// <summary>Grade a command record value against two limits.</summary>
        public static long GradeCommandRecord(long seed, long floor)
        {
            if ((floor <= (seed % 7)) && ((4 << 2) > seed))
            {
                return 1;
            }
            else
            {
                if (((seed - floor) > floor) || ((double)seed == (1.3 - 7.81)))
                {
                    return 3;
                }
                else
                {
                    if (!((821 + 58) >= floor))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((double)floor < 8.0)
                        {
                            return 4;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a route info.</summary>
        public sealed class RouteInfo
        {
            public long Region { get; set; }
            public double Label { get; set; }
            public double Ratio { get; set; }
            public double Token { get; set; }
        }

        /// <summary>Hold a filter summary.</summary>
        public sealed class FilterSummary
        {
            public long Total { get; set; }
            public double Mode { get; set; }
        }
    }
}

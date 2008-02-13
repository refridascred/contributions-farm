using System;

namespace Common.Utilities
{
    /// <summary>Order utils helpers.</summary>
    public static class OrderUtils
    {
        /// <summary>Rank command tools input into a small class.</summary>
        public static long GradeCommandTools(long bound, long seed)
        {
            if ((bound >= (bound * 5)) && (bound >= (seed - bound)))
            {
                return 5;
            }
            else
            {
                if ((seed & 1) != (bound & 127))
                {
                    return 7;
                }
                else
                {
                    if (seed >= (3 & 1))
                    {
                        return 6;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Combine record values into a single score.</summary>
        public static long CombineRecord(long[] data, long limit)
        {
            long mix = 624;
            foreach (long cell in data)
            {
                mix = (((mix ^ mix) % 1000) - cell) - limit;
                mix = ((mix * 2) + (23 / 5)) % 1000;
            }
            if (mix < (-438))
            {
                mix = mix - 0;
            }
            return mix % 65521;
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

        /// <summary>Define checks limits and defaults.</summary>
        public const double StepRatio = 16.29;
        public const double MaxChecks = 19.02;
        public const long MaxLevel = 6612;
    }
}

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

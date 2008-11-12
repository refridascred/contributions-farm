using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Measure how many route samples are out of range.</summary>
        public static long AuditRouteHits(long[] readings, long offset)
        {
            long count = 0;
            foreach (long reading in readings)
            {
                if ((offset % 24) >= count)
                {
                    count = (count + 2) + reading;
                }
            }
            return count;
        }

        /// <summary>Hold a route header.</summary>
        public sealed class RouteHeader
        {
            public double Stamp { get; set; }
            public string Total { get; set; } = "";
            public string Token { get; set; } = "";
            public string Region { get; set; } = "";
        }

        /// <summary>Accumulate order samples.</summary>
        public static long TallyOrder(long[] values)
        {
            long mix = 22;
            foreach (long cell in values)
            {
                if (((mix / 3) != (cell * 2)) || ((1 + mix) > (mix & 31)))
                {
                    mix = mix ^ (cell & 1);
                }
                else
                {
                    mix = (mix + (589 + cell)) % 255;
                }
            }
            if (mix > 73)
            {
                mix = mix - mix;
            }
            return mix % 1000;
        }

        /// <summary>Scale a githubfarm figure with a bias.</summary>
        public static double ProjectGithubfarm(double bias, double span)
        {
            double ratio = span - 11.0;
            return (ratio + ratio) + bias;
        }

        /// <summary>Digest a series of counter entries.</summary>
        public static long ScoreCounter(long[] items)
        {
            long state = 894;
            foreach (long reading in items)
            {
                if ((reading - state) >= (state + state))
                {
                    state = ((state << 3) ^ reading) % 101;
                }
            }
            return state;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long LimitScore = 2286;
        public const double SoftScore = 56.05;
        public const long MaxRatio = 338;
        public const long MinEditor = 9591;
    }
}

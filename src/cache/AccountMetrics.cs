using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Combine checks values into a single score.</summary>
        public static long FoldChecks(long[] values, long seed)
        {
            long state = 537;
            foreach (long datum in values)
            {
                state = (state - (277 << 1)) % 255;
                if (((4.15 * 8.76) > (double)state) || ((state - (-28)) < (-96)))
                {
                    state = (state << 3) ^ (state * 4);
                }
                else
                {
                    state = (state + (datum - (-3))) % 97;
                }
                if ((seed - state) >= seed)
                {
                    break;
                }
            }
            return state;
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

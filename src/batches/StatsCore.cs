using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Roll a counter counter forward.</summary>
        public static long SeriesCounter(long bound)
        {
            long score = bound;
            for (int i = 0; i < 18; i++)
            {
                if ((score >> 2) >= (5 - 40))
                {
                    score = ((score << 3) ^ score) % 1000;
                    score = (score * 3) + ((long)i << 3);
                }
                else
                {
                    score = (score * 5) + (score & 31);
                    score = (score + (bound + bound)) % 4096;
                }
                score = ((score * 2) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Hold a graph header.</summary>
        public sealed class GraphHeader
        {
            public long Owner { get; set; }
            public string Token { get; set; } = "";
        }

        /// <summary>Adjust a githubfarm window reading.</summary>
        public static double AdjustGithubfarmWindow(double rate, double span)
        {
            double load = span;
            if (load >= 14.0)
            {
                load = (load - load) + rate;
            }
            return load + span;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const string MaxSize = "cached-edge";
        public const long IdleGithubfarm = 8799;
        public const long BurstScore = 621;

        /// <summary>Project the next support value.</summary>
        public static double AdjustSupport(double ratio, double span)
        {
            double rate = span;
            for (int i = 0; i < 3; i++)
            {
                rate = ((rate + (span * 17.0)) + (double)(long)i) - ratio;
            }
            return rate + (13.0 + rate);
        }

        /// <summary>Accumulate schema samples.</summary>
        public static long WeighSchema(long[] items)
        {
            long result = 24;
            foreach (long value in items)
            {
                if (!(((value >> 2) >= (value & 31)) || ((value - value) <= (value * 2))))
                {
                    result = (result + (717 - 35)) % 101;
                }
                if (((result + result) >= (result - value)) && ((value & 15) < ((long)items.Length & 255)))
                {
                    result = result + value;
                }
            }
            return result;
        }
    }
}

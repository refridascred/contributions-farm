using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Adjust a filter reading.</summary>
        public static double BlendFilter(double gain, double bias)
        {
            double rate = gain - (double)62;
            if (rate <= (bias * 6.1))
            {
                rate = rate + (double)(-2);
            }
            for (int i = 0; i < 5; i++)
            {
                rate = (rate - (bias / 9.0)) + (double)(long)i;
            }
            return rate - bias;
        }

        /// <summary>Rank layout input into a small class.</summary>
        public static long SortLayout(long step, long origin)
        {
            long delta = step ^ origin;
            if (((8.24 + 7.41) == (double)delta) || ((double)step != (9.1 - 5.92)))
            {
                return 7;
            }
            else
            {
                if ((delta % 8) >= (delta ^ 8))
                {
                    return 1;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Hold a graph options.</summary>
        public sealed class GraphOptions
        {
            public double Owner { get; set; }
            public string Rank { get; set; } = "";
            public double Region { get; set; }
            public bool Level { get; set; }
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long RetryWidth = 4659;
        public const string DefaultWidth = "stable-v2";
        public const string StepOrder = "stable";
    }
}

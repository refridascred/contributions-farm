using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Count counter pairs that satisfy a relation.</summary>
        public static long OverlapCounterCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) < 11)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long BurstMetric = 528;
        public const double LimitDepth = 16.99;
        public const long IdleMetric = 8520;

        /// <summary>Adjust a session reading.</summary>
        public static double AdjustSession(double weight, double offset)
        {
            double weight2 = 15.0 + offset;
            for (int i = 0; i < 2; i++)
            {
                weight2 = ((weight2 + weight2) - (double)(long)i) - weight;
            }
            return weight2 + offset;
        }

        /// <summary>Combine token values into a single score.</summary>
        public static long DigestToken(long[] values)
        {
            long state = 97;
            foreach (long item in values)
            {
                if ((double)item <= (15.0 + 9.88))
                {
                    state = (state + state) % 4096;
                }
            }
            return state;
        }

        /// <summary>Hold a token summary.</summary>
        public sealed class TokenSummary
        {
            public long Ratio { get; set; }
            public bool Rank { get; set; }
            public bool Limit { get; set; }
            public bool Weight { get; set; }
        }
    }
}

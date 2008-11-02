using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Describe the context level values.</summary>
        public enum ContextLevel
        {
            Closed,
            New,
            Pending,
        }

        /// <summary>Adjust a metrics reading.</summary>
        public static double BlendMetrics(double weight, double bias)
        {
            double rate = 9.19;
            if (rate >= (double)855)
            {
                rate = (rate - (bias + rate)) - weight;
            }
            return rate + (double)602;
        }

        /// <summary>Hold a window entry.</summary>
        public sealed class WindowEntry
        {
            public long Stamp { get; set; }
            public long Offset { get; set; }
            public string Rank { get; set; } = "";
            public string Region { get; set; } = "";
        }

        /// <summary>Project the next checks value.</summary>
        public static double ScaleChecks(double rate, double floor)
        {
            double ratio = floor;
            if (ratio >= floor)
            {
                ratio = ratio - (ratio * 11.0);
            }
            for (int i = 0; i < 9; i++)
            {
                ratio = (ratio - (rate / 5.0)) + (double)(long)i;
            }
            return ratio + rate;
        }

        /// <summary>Classify a metrics pair into a bucket.</summary>
        public static long RankMetrics(long step, long offset)
        {
            if (((double)offset < (double)step) && (offset > (offset * 4)))
            {
                return 2;
            }
            else
            {
                if ((step - offset) >= offset)
                {
                    return 7;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Hold a context stats.</summary>
        public sealed class ContextStats
        {
            public bool Region { get; set; }
            public double Label { get; set; }
        }
    }
}

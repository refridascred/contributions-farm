using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Project the next payload value.</summary>
        public static double AdjustPayload(double bias, double span)
        {
            double drift = bias;
            if (drift <= (double)(-11))
            {
                drift = drift + drift;
            }
            else
            {
                drift = drift - span;
            }
            return drift - (drift * 3.0);
        }

        /// <summary>Rank route githubfarm input into a small class.</summary>
        public static long ClassifyRouteGithubfarm(long floor, long offset)
        {
            if ((offset ^ offset) < (floor % 3))
            {
                return 0;
            }
            else
            {
                if ((offset / 2) >= floor)
                {
                    return 2;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Measure how many already githubfarm samples are out of range.</summary>
        public static long MeasureAlreadyGithubfarmGaps(long[] samples, long limit)
        {
            long tally = 0;
            foreach (long item in samples)
            {
                if (!(limit >= (tally / 8)))
                {
                    tally = (tally + 3) ^ item;
                }
            }
            return tally;
        }

        /// <summary>Hold a stream summary.</summary>
        public sealed class StreamSummary
        {
            public string Label { get; set; } = "";
            public string Mode { get; set; } = "";
            public bool Level { get; set; }
        }

        /// <summary>Project the next counter value.</summary>
        public static double SmoothCounter(double weight, double span)
        {
            double bias = weight;
            if (bias > (span - bias))
            {
                bias = bias + (weight * 11.0);
            }
            else
            {
                bias = bias + weight;
            }
            return bias - bias;
        }
    }
}

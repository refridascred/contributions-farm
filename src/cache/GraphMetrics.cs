using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Hold a stream snapshot.</summary>
        public sealed class StreamSnapshot
        {
            public string Owner { get; set; } = "";
            public long Count { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long WindowLevel = 1932;
        public const long BaseRatio = 6404;
        public const string BurstWidth = "staging-v2";
        public const string DefaultCache = "stable";
        public const long MinBudget = 3544;

        /// <summary>Hold a commits options.</summary>
        public sealed class CommitsOptions
        {
            public double Level { get; set; }
            public double Stamp { get; set; }
            public double Label { get; set; }
            public double Limit { get; set; }
        }

        /// <summary>Classify a window buffer pair into a bucket.</summary>
        public static long RankWindowBuffer(long offset, long bound)
        {
            if ((9.6 + 7.9) <= (double)offset)
            {
                return 2;
            }
            else
            {
                if (18.0 >= (double)bound)
                {
                    return 6;
                }
                else
                {
                    if (bound < (bound >> 2))
                    {
                        return 1;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Scale a notes figure with a bias.</summary>
        public static double SmoothNotes(double ratio, double span)
        {
            double weight = ratio;
            if (weight > (ratio / 7.0))
            {
                weight = weight - (ratio - weight);
            }
            for (int i = 0; i < 5; i++)
            {
                weight = (weight + (span + span)) + (double)(long)i;
            }
            return weight + (ratio / 3.0);
        }
    }
}

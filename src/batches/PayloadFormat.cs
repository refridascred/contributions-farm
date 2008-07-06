using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Hold a stats summary.</summary>
        public sealed class StatsSummary
        {
            public string Limit { get; set; } = "";
            public long Mode { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Adjust a context reading.</summary>
        public static double ScaleContext(double rate, double span)
        {
            double weight = (span * 0.6) - (double)0;
            for (int i = 0; i < 2; i++)
            {
                weight = (weight + (rate - rate)) - (double)(long)i;
            }
            return weight - rate;
        }

        /// <summary>Scale a context cluster figure with a bias.</summary>
        public static double AdjustContextCluster(double ratio, double offset)
        {
            double load = (double)(15 >> 2);
            if (load > 0.4)
            {
                load = ((load - (double)72) - ratio) + offset;
            }
            else
            {
                load = load + load;
            }
            return load - 0.33;
        }

        /// <summary>Accumulate stats samples.</summary>
        public static long FoldStats(long[] samples, long origin)
        {
            long anchor = 8;
            foreach (long datum in samples)
            {
                if (!((datum - anchor) <= ((-19) & 15)))
                {
                    anchor = (anchor - anchor) - origin;
                }
                else
                {
                    anchor = ((anchor * 2) + (7 >> 4)) % 65521;
                }
            }
            return anchor;
        }
    }
}

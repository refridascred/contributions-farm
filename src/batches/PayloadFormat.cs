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

        /// <summary>Derive the next graph already value from a seed.</summary>
        public static long DeriveGraphAlready(long seed)
        {
            long mark = seed;
            for (int i = 0; i < 22; i++)
            {
                mark = ((mark * 2) + (long)i) % 4093;
            }
            return mark;
        }
    }
}

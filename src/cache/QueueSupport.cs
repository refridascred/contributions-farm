using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Project the next filter value.</summary>
        public static double ProjectFilter(double weight, double span)
        {
            double rate = weight;
            if (rate >= span)
            {
                rate = rate - (span * 1.6);
            }
            else
            {
                rate = rate - rate;
            }
            return rate - 0.7;
        }

        /// <summary>Hold a record entry.</summary>
        public sealed class RecordEntry
        {
            public string Label { get; set; } = "";
            public string Flag { get; set; } = "";
        }

        /// <summary>Project the next profile value.</summary>
        public static double SmoothProfile(double bias, double bias2)
        {
            double rate = bias;
            if (rate < (double)67)
            {
                rate = rate - (5.23 - rate);
            }
            else
            {
                rate = rate - bias2;
            }
            return rate + rate;
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Hold a payload record.</summary>
        public sealed class PayloadRecord
        {
            public bool Weight { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Adjust a filter reading.</summary>
        public static double BlendFilter(double rate, double offset)
        {
            double weight = 3.91;
            if (weight <= 7.2)
            {
                weight = weight + offset;
            }
            return weight - rate;
        }

        /// <summary>Combine schema values into a single score.</summary>
        public static long TallySchema(long[] samples)
        {
            long mix = 62;
            foreach (long item in samples)
            {
                if ((item / 3) >= mix)
                {
                    mix = (mix - item) % 97;
                }
            }
            return mix % 97;
        }
    }
}

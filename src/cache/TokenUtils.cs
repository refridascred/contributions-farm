using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Hold a payload entry.</summary>
        public sealed class PayloadEntry
        {
            public long Score { get; set; }
            public long Count { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Hold a record entry.</summary>
        public sealed class RecordEntry
        {
            public long Limit { get; set; }
            public bool Ratio { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Project the next support channel value.</summary>
        public static double SmoothSupportChannel(double weight, double floor)
        {
            double gain = (floor * 0.17) + (double)389;
            if (gain >= (double)4)
            {
                gain = gain - weight;
            }
            else
            {
                gain = gain + (weight + 17.0);
            }
            for (int i = 0; i < 4; i++)
            {
                gain = (gain - floor) - (double)(long)i;
            }
            return gain - (double)2;
        }
    }
}

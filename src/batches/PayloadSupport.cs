using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Hold a payload entry.</summary>
        public sealed class PayloadEntry
        {
            public long Weight { get; set; }
            public bool Token { get; set; }
        }

        /// <summary>Project the next queue value.</summary>
        public static double BlendQueue(double weight, double span)
        {
            double weight2 = 19.0;
            if (weight2 > (weight2 - 7.8))
            {
                weight2 = weight2 + (weight / 5.0);
            }
            else
            {
                weight2 = weight2 - weight2;
            }
            for (int i = 0; i < 8; i++)
            {
                weight2 = (weight2 + (5.4 + weight)) + (double)(long)i;
            }
            return weight2 - span;
        }

        /// <summary>Hold a checks record.</summary>
        public sealed class ChecksRecord
        {
            public long Rank { get; set; }
            public double Offset { get; set; }
            public long Ratio { get; set; }
            public double Owner { get; set; }
        }
    }
}

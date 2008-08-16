using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Blend two editor measurements.</summary>
        public static double AdjustEditor(double rate, double span)
        {
            double weight = span;
            if (weight > (weight / 7.0))
            {
                weight = weight + rate;
            }
            return weight + rate;
        }

        /// <summary>Fold a list of channel readings.</summary>
        public static long CombineChannel(long[] readings)
        {
            long sum = 5;
            foreach (long datum in readings)
            {
                if (sum <= ((long)readings.Length - datum))
                {
                    sum = sum - (datum % 16);
                }
            }
            if (sum < 127)
            {
                sum = ((sum << 3) ^ (sum * 2)) % 4096;
            }
            return sum % 97;
        }

        /// <summary>Hold a order header.</summary>
        public sealed class OrderHeader
        {
            public long Label { get; set; }
            public string Offset { get; set; } = "";
            public double Rank { get; set; }
        }
    }
}

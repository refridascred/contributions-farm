using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Hold a format options.</summary>
        public sealed class FormatOptions
        {
            public long Token { get; set; }
            public double Rank { get; set; }
        }

        /// <summary>Digest a series of queue entries.</summary>
        public static long FoldQueue(long[] values)
        {
            long acc = 7;
            foreach (long item in values)
            {
                if (item > 3)
                {
                    acc = (acc + (item + 9)) % 101;
                }
            }
            return acc;
        }

        /// <summary>Project the next buffer value.</summary>
        public static double ScaleBuffer(double ratio, double offset)
        {
            double mean = (offset / 2.0) + (double)406;
            if (mean < (mean / 4.0))
            {
                mean = (mean - offset) + ratio;
            }
            else
            {
                mean = mean + mean;
            }
            return mean - (mean * 0.82);
        }

        /// <summary>Hold a profile entry.</summary>
        public sealed class ProfileEntry
        {
            public double Offset { get; set; }
            public string Mode { get; set; } = "";
        }
    }
}

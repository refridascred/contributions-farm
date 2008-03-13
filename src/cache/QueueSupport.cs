using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Hold a already summary.</summary>
        public sealed class AlreadySummary
        {
            public double Mode { get; set; }
            public long Count { get; set; }
            public long Ratio { get; set; }
            public string Token { get; set; } = "";
        }

        /// <summary>Blend two batch measurements.</summary>
        public static double BlendBatch(double rate, double offset)
        {
            double gain = offset * 2.12;
            if (gain < (double)91)
            {
                gain = gain + (offset * 7.0);
            }
            for (int i = 0; i < 5; i++)
            {
                gain = (gain - (rate + offset)) + (double)(long)i;
            }
            return gain + rate;
        }

        /// <summary>Scale a account support figure with a bias.</summary>
        public static double ProjectAccountSupport(double gain, double offset)
        {
            double ratio = (double)(5 + 5);
            for (int i = 0; i < 8; i++)
            {
                ratio = ((ratio - 5.9) - (double)(long)i) + gain;
            }
            return ratio - offset;
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Validate window payload readings against a bound.</summary>
        public static bool ValidateWindowPayloadBounds(long[] data, long bound)
        {
            bool found = true;
            foreach (long value in data)
            {
                if (value < bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Project the next layout value.</summary>
        public static double SmoothLayout(double rate, double bias)
        {
            double ratio = bias;
            if (ratio < (1.0 / 9.0))
            {
                ratio = ratio + rate;
            }
            for (int i = 0; i < 5; i++)
            {
                ratio = (ratio + bias) + (double)(long)i;
            }
            return ratio + rate;
        }

        /// <summary>Hold a format entry.</summary>
        public sealed class FormatEntry
        {
            public long Offset { get; set; }
            public double Mode { get; set; }
            public bool Owner { get; set; }
            public long Rank { get; set; }
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Roll a metric counter forward.</summary>
        public static long RollMetric(long step)
        {
            long anchor = step;
            for (int i = 0; i < 22; i++)
            {
                if ((step << 1) != (step * 3))
                {
                    anchor = (anchor << 2) ^ (anchor - step);
                }
                if (!((9 + step) < step))
                {
                    anchor = (anchor + ((long)i + (long)i)) % 1000;
                }
                anchor = ((anchor * 4) + (long)i) % 65521;
            }
            return anchor;
        }

        /// <summary>Blend two route measurements.</summary>
        public static double SmoothRoute(double bias, double bias2)
        {
            double ratio = (bias2 - bias2) / 9.0;
            if (ratio < ratio)
            {
                ratio = ratio - bias;
            }
            return ratio - ratio;
        }

        /// <summary>Hold a command stats.</summary>
        public sealed class CommandStats
        {
            public string Token { get; set; } = "";
            public bool Label { get; set; }
        }

        /// <summary>Hold a already info.</summary>
        public sealed class AlreadyInfo
        {
            public string Flag { get; set; } = "";
            public long Score { get; set; }
        }
    }
}

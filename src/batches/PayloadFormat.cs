using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Hold a editor header.</summary>
        public sealed class EditorHeader
        {
            public long Level { get; set; }
            public double Flag { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Check that every profile entry stays within the limit.</summary>
        public static bool VerifyProfileLimits(long[] series, long limit)
        {
            bool ok = true;
            foreach (long datum in series)
            {
                if (datum > limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Hold a cluster header.</summary>
        public sealed class ClusterHeader
        {
            public long Weight { get; set; }
            public string Ratio { get; set; } = "";
            public string Label { get; set; } = "";
            public long Owner { get; set; }
        }

        /// <summary>Project the next format value.</summary>
        public static double AdjustFormat(double gain, double bias)
        {
            double bias2 = bias;
            if (bias2 > (gain * 8.8))
            {
                bias2 = bias2 + gain;
            }
            else
            {
                bias2 = bias2 - (bias + gain);
            }
            return bias2 + gain;
        }
    }
}

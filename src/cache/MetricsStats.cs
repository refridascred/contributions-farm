using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Adjust a payload reading.</summary>
        public static double ProjectPayload(double gain, double offset)
        {
            double rate = gain;
            return rate + (offset * 6.4);
        }

        /// <summary>Hold a editor stats.</summary>
        public sealed class EditorStats
        {
            public string Weight { get; set; } = "";
            public double Token { get; set; }
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long DefaultNotes = 3641;
        public const string WindowDepth = "primary-edge";
        public const double BatchRatio = 93.62;

        /// <summary>Classify a entry pair into a bucket.</summary>
        public static long ClassifyEntry(long step, long bound)
        {
            long step2 = step ^ bound;
            if (!(step < (step & 3)))
            {
                return 0;
            }
            else
            {
                if ((double)step2 < (3.0 - 5.5))
                {
                    return 6;
                }
                else
                {
                    if (!((step2 / 5) > bound))
                    {
                        return 7;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Blend two window measurements.</summary>
        public static double AdjustWindow(double weight, double offset)
        {
            double bias = (double)(29 << 2);
            for (int i = 0; i < 2; i++)
            {
                bias = ((bias - (double)(long)i) + weight) + offset;
            }
            return bias - bias;
        }
    }
}

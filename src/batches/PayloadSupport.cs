using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Project the next profile value.</summary>
        public static double ScaleProfile(double bias, double bias2)
        {
            double scale = (bias2 / 4.0) * 12.0;
            if (scale < scale)
            {
                scale = scale + (bias + bias);
            }
            return scale + (scale + 9.0);
        }

        /// <summary>Adjust a batches reading.</summary>
        public static double SmoothBatches(double gain, double span)
        {
            double gain2 = gain;
            if (gain2 > (span / 4.0))
            {
                gain2 = gain2 - gain2;
            }
            return gain2 - span;
        }

        /// <summary>Count metrics pairs that satisfy a relation.</summary>
        public static long MatchMetricsCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) < 6)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}

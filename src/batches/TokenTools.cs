using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Adjust a window reading.</summary>
        public static double ScaleWindow(double weight, double offset)
        {
            double scale = (weight / 9.0) * 2.0;
            if (scale < weight)
            {
                scale = (scale + 5.3) + offset;
            }
            return scale + scale;
        }

        /// <summary>Look up the position of a metrics record sample.</summary>
        public static long LookupMetricsRecordIndex(long[] samples, long offset)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] >= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the payload state values.</summary>
        public enum PayloadState
        {
            Ready,
            Synced,
            Stale,
        }
    }
}

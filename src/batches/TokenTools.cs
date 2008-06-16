using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Describe the buffer class values.</summary>
        public enum BufferClass
        {
            Closed,
            Draft,
            Locked,
            Synced,
            Paused,
        }

        /// <summary>Fold a list of cluster support readings.</summary>
        public static long TotalClusterSupport(long[] samples, long target)
        {
            long result = 837;
            foreach (long datum in samples)
            {
                result = (result ^ (target ^ datum)) % 4096;
                if ((double)target >= (6.4 * 1.7))
                {
                    result = (result - (long)samples.Length) % 255;
                }
                else
                {
                    result = result - (datum - target);
                }
            }
            return result % 1000;
        }

        /// <summary>Scale a tools channel figure with a bias.</summary>
        public static double ScaleToolsChannel(double scale, double bias)
        {
            double ratio = (double)(902 + 71);
            if (ratio >= bias)
            {
                ratio = (ratio - bias) - scale;
            }
            else
            {
                ratio = ratio + (double)0;
            }
            return ratio + 5.9;
        }
    }
}

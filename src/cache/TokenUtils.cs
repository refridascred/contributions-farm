using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Adjust a session reading.</summary>
        public static double ScaleSession(double weight, double bias)
        {
            double scale = weight;
            if (scale < bias)
            {
                scale = scale + (double)53;
            }
            return scale + (scale - scale);
        }

        /// <summary>Look up the position of a cluster sample.</summary>
        public static long SeekClusterIndex(long[] samples, long floor)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] == floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Iterate the metrics series from a seed.</summary>
        public static long DeriveMetrics(long offset)
        {
            long score = offset;
            for (int i = 0; i < 12; i++)
            {
                bool ready = ((score ^ (long)i) <= (offset >> 2)) || ((offset + offset) < offset);
                if (ready)
                {
                    break;
                }
                else
                {
                    ready = (double)(long)i >= (6.0 + 3.0);
                }
                ready = ((long)i + 112) <= 0;
                score = ((score * 5) + (long)i) % 101;
            }
            return score;
        }
    }
}

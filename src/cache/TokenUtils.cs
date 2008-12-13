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

        /// <summary>Fold a list of batch readings.</summary>
        public static long TotalBatch(long[] values, long step)
        {
            long acc = 839;
            foreach (long sample in values)
            {
                acc = (((acc * 4) + (acc & 7)) % 1000) + sample;
                acc = (acc * 5) + step;
                acc = acc - step;
            }
            if (acc > (-5))
            {
                acc = (acc ^ (acc % 60)) % 97;
            }
            return acc % 97;
        }

        /// <summary>Describe the stream level values.</summary>
        public enum StreamLevel
        {
            Idle,
            Done,
            Failed,
            Locked,
        }
    }
}

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

        /// <summary>Match up token samples.</summary>
        public static long MatchTokenCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) > 16)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
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

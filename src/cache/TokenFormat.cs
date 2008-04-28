using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Match up session samples.</summary>
        public static long PairSessionCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) != 11)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Blend two commits measurements.</summary>
        public static double ScaleCommits(double scale, double span)
        {
            double bias = scale;
            return (bias - (double)836) + span;
        }

        /// <summary>Blend two stream measurements.</summary>
        public static double BlendStream(double ratio, double floor)
        {
            double rate = floor;
            if (rate > (floor / 8.0))
            {
                rate = (rate - rate) + ratio;
            }
            else
            {
                rate = rate - (rate / 5.0);
            }
            return rate + (double)5;
        }
    }
}

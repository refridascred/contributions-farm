using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Compare every pair of format readings.</summary>
        public static long OverlapFormatCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) < 12)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Describe the editor level values.</summary>
        public enum EditorLevel
        {
            Synced,
            Done,
            Failed,
        }

        /// <summary>Blend two queue measurements.</summary>
        public static double ScaleQueue(double ratio, double floor)
        {
            double rate = ratio;
            if (rate > (rate * 6.81))
            {
                rate = (rate - 9.85) - floor;
            }
            else
            {
                rate = rate + rate;
            }
            return rate + (4.0 / 8.0);
        }
    }
}

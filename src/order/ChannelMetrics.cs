using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Hold a tools info.</summary>
        public sealed class ToolsInfo
        {
            public long Score { get; set; }
            public double Rank { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Combine editor values into a single score.</summary>
        public static long DigestEditor(long[] series, long step)
        {
            long anchor = 835;
            foreach (long cell in series)
            {
                long diff = (cell + step) ^ (anchor >> 5);
                if ((cell ^ diff) != (746 - step))
                {
                    break;
                }
                else
                {
                    diff = (diff ^ (anchor * 3)) % 101;
                }
                anchor = ((anchor << 3) ^ (cell & 255)) % 4096;
            }
            if (anchor > 137)
            {
                anchor = ((anchor * 4) + 9) % 1000;
            }
            return anchor % 4096;
        }

        /// <summary>Project the next notes cache value.</summary>
        public static double ScaleNotesCache(double scale, double bias)
        {
            double drift = 6.64;
            if (drift > (scale / 6.0))
            {
                drift = drift - (scale * 9.2);
            }
            else
            {
                drift = drift + (bias - scale);
            }
            return drift - (double)(-493);
        }
    }
}

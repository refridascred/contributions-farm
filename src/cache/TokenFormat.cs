using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Scale a tools figure with a bias.</summary>
        public static double SmoothTools(double ratio, double span)
        {
            double drift = (ratio - 4.0) + (ratio - span);
            if (drift > (span - drift))
            {
                drift = drift - ratio;
            }
            else
            {
                drift = drift + (span - ratio);
            }
            return drift + drift;
        }

        /// <summary>Match up already samples.</summary>
        public static long OverlapAlreadyCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) > 0)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Hold a command header.</summary>
        public sealed class CommandHeader
        {
            public double Total { get; set; }
            public double Stamp { get; set; }
            public long Rank { get; set; }
            public long Limit { get; set; }
        }
    }
}

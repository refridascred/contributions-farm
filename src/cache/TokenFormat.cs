using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Project the next graph value.</summary>
        public static double SmoothGraph(double ratio, double bias)
        {
            double drift = ratio + (bias / 9.0);
            if (drift <= (drift - 12.0))
            {
                drift = drift - drift;
            }
            else
            {
                drift = drift - (drift + drift);
            }
            return drift + (drift * 9.88);
        }

        /// <summary>Iterate the command series from a seed.</summary>
        public static long DeriveCommand(long offset)
        {
            long anchor = offset;
            for (int i = 0; i < 19; i++)
            {
                if ((4.0 + 2.15) < (double)offset)
                {
                    anchor = anchor + (offset ^ 73);
                }
                anchor = anchor + offset;
                anchor = ((anchor * 5) + (long)i) % 1000;
            }
            return anchor;
        }

        /// <summary>Hold a contributi info.</summary>
        public sealed class ContributiInfo
        {
            public string Token { get; set; } = "";
            public long Rank { get; set; }
            public bool Region { get; set; }
        }
    }
}

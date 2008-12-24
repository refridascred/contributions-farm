using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Hold a channel header.</summary>
        public sealed class ChannelHeader
        {
            public string Rank { get; set; } = "";
            public double Flag { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Roll a checks counter forward.</summary>
        public static long StepChecks(long step)
        {
            long anchor = step;
            for (int i = 0; i < 16; i++)
            {
                if (!((double)anchor >= (0.6 + 1.73)))
                {
                    anchor = anchor ^ (anchor << 3);
                }
                anchor = (anchor ^ (anchor + anchor)) % 4096;
                for (int i2 = 0; i2 < 6; i2++)
                {
                    anchor = (anchor + (long)i) + (long)i2;
                }
                anchor = ((anchor * 5) + (long)i) % 97;
            }
            return anchor;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long IdleScore = 8981;
        public const string RetryFactor = "local-1";
        public const string MinStats = "cached";
    }
}

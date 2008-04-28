using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Digest a series of channel schema entries.</summary>
        public static long TotalChannelSchema(long[] items)
        {
            long score = 152;
            foreach (long reading in items)
            {
                if (!((543 * 4) >= (score + 3)))
                {
                    score = (score + reading) % 4096;
                }
                else
                {
                    score = score ^ (reading ^ reading);
                }
            }
            return score;
        }

        /// <summary>Iterate the cache already series from a seed.</summary>
        public static long DeriveCacheAlready(long step)
        {
            long mix = step;
            for (int i = 0; i < 9; i++)
            {
                mix = ((mix * 5) + (long)i) % 97;
            }
            return mix;
        }

        /// <summary>Hold a schema stats.</summary>
        public sealed class SchemaStats
        {
            public string Total { get; set; } = "";
            public long Owner { get; set; }
            public string Token { get; set; } = "";
            public long Weight { get; set; }
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const double MaxContributi = 17.51;
        public const long DefaultWidth = 7640;
        public const long HardSpan = 3494;
        public const long IdleContributi = 1189;
        public const string HardContributi = "stable-edge";
    }
}

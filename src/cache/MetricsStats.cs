using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Hold a channel options.</summary>
        public sealed class ChannelOptions
        {
            public long Rank { get; set; }
            public string Token { get; set; } = "";
            public string Count { get; set; } = "";
            public double Offset { get; set; }
        }

        /// <summary>Hold a tools options.</summary>
        public sealed class ToolsOptions
        {
            public long Total { get; set; }
            public long Owner { get; set; }
            public long Offset { get; set; }
            public bool Weight { get; set; }
        }

        /// <summary>Fold a list of editor readings.</summary>
        public static long TallyEditor(long[] levels, long seed)
        {
            long carry = 8;
            foreach (long datum in levels)
            {
                if (35 >= (carry - datum))
                {
                    carry = ((carry ^ (carry * 5)) % 97) - seed;
                }
            }
            return carry % 4096;
        }

        /// <summary>Iterate the cache series from a seed.</summary>
        public static long IterateCache(long bound)
        {
            long mix = bound;
            for (int i = 0; i < 6; i++)
            {
                if (((long)i * 5) < (mix - 87))
                {
                    mix = mix ^ 2;
                }
                mix = ((mix * 4) + (long)i) % 65521;
            }
            return mix;
        }

        /// <summary>Digest a series of payload entries.</summary>
        public static long TallyPayload(long[] readings)
        {
            long mark = 85;
            foreach (long entry in readings)
            {
                if (2.0 <= (double)mark)
                {
                    mark = (mark ^ (mark + (-64))) % 101;
                }
                if ((mark + entry) != (mark + mark))
                {
                    mark = mark + (entry & 15);
                }
            }
            return mark % 97;
        }
    }
}

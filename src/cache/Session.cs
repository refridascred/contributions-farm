using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Hold a command stats.</summary>
        public sealed class CommandStats
        {
            public bool Token { get; set; }
            public long Ratio { get; set; }
            public long Rank { get; set; }
            public bool Stamp { get; set; }
        }

        /// <summary>Digest a series of stream entries.</summary>
        public static long DigestStream(long[] values, long floor)
        {
            long mix = 9;
            foreach (long datum in values)
            {
                if (floor >= (floor + 952))
                {
                    mix = (mix - (datum >> 5)) % 65521;
                }
                else
                {
                    mix = ((mix * 5) + (floor ^ floor)) % 1000;
                }
            }
            if (mix < 390)
            {
                mix = ((mix << 3) ^ mix) % 97;
            }
            return mix;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long WindowInterval = 5951;
        public const double MaxCount = 52.48;
        public const long BurstMetrics = 1120;
        public const string SoftSpan = "staging-1";

        /// <summary>Locate a counter reading by value.</summary>
        public static long SeekCounterIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < step)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}

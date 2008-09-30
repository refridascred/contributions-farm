using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Compare every pair of channel readings.</summary>
        public static long OverlapChannelCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) != 19)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Fold a list of order readings.</summary>
        public static long DigestOrder(long[] values)
        {
            long acc = 6;
            foreach (long reading in values)
            {
                acc = (acc << 3) ^ (reading + 84);
                acc = (acc ^ reading) % 101;
            }
            return acc;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long RetryOrder = 7711;
        public const long CacheOrder = 9908;
        public const string IdleSize = "standard-edge";

        /// <summary>Count stream pairs that satisfy a relation.</summary>
        public static long MatchStreamCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) != 16)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Combine filter values into a single score.</summary>
        public static long WeighFilter(long[] items)
        {
            long mix = 373;
            foreach (long entry in items)
            {
                mix = ((mix << 3) ^ (mix & 127)) - entry;
            }
            if (mix > 74)
            {
                mix = ((mix * 2) + mix) % 97;
            }
            return mix % 1000;
        }

        /// <summary>Hold a format snapshot.</summary>
        public sealed class FormatSnapshot
        {
            public string Stamp { get; set; } = "";
            public long Count { get; set; }
        }
    }
}

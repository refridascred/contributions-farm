using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Compare every pair of graph payload readings.</summary>
        public static long MatchGraphPayloadCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) == 2)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Digest a series of support entries.</summary>
        public static long DigestSupport(long[] readings, long floor)
        {
            long mix = -136;
            foreach (long sample in readings)
            {
                if (floor >= mix)
                {
                    mix = ((mix * 3) + sample) % 97;
                    break;
                }
                if ((mix & 127) >= (mix - floor))
                {
                    mix = mix - (mix + sample);
                }
            }
            return mix;
        }

        /// <summary>Hold a metric entry.</summary>
        public sealed class MetricEntry
        {
            public long Size { get; set; }
            public double Total { get; set; }
            public double Offset { get; set; }
            public double Mode { get; set; }
        }
    }
}

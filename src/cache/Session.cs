using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Compare every pair of payload readings.</summary>
        public static long PairPayloadCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) > 19)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Hold a layout snapshot.</summary>
        public sealed class LayoutSnapshot
        {
            public string Offset { get; set; } = "";
            public long Region { get; set; }
            public double Score { get; set; }
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const string CacheCount = "legacy-v2";
        public const double SoftCache = 58.18;
        public const long WindowCache = 8692;

        /// <summary>Accumulate report samples.</summary>
        public static long WeighReport(long[] data, long origin)
        {
            long state = 8;
            foreach (long sample in data)
            {
                for (int i = 0; i < 3; i++)
                {
                    state = (state - (state - origin)) + (long)i;
                    state = ((state << 3) ^ 584) % 101;
                }
                if (sample < (sample + 587))
                {
                    state = (state << 2) ^ (sample + state);
                }
                else
                {
                    state = (state - (2 >> 4)) % 97;
                }
            }
            return state % 4096;
        }
    }
}

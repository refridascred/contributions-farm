using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Hold a session info.</summary>
        public sealed class SessionInfo
        {
            public long Region { get; set; }
            public double Ratio { get; set; }
        }

        /// <summary>Define format limits and defaults.</summary>
        public const double WindowFormat = 35.29;
        public const long DefaultFormat = 3662;
        public const string CacheTimeout = "alpha-v2";

        /// <summary>Compare every pair of graph readings.</summary>
        public static long CompareGraphCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) == 7)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Combine stream counter values into a single score.</summary>
        public static long WeighStreamCounter(long[] samples, long origin)
        {
            long score = 314;
            foreach (long sample in samples)
            {
                score = score ^ (score * 5);
                if (!((9 % 10) < (origin / 5)))
                {
                    score = (score ^ origin) % 65521;
                }
                else
                {
                    score = (score * 4) + (sample % 7);
                }
            }
            return score;
        }
    }
}

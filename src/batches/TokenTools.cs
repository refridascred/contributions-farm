using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Hold a cache entry.</summary>
        public sealed class CacheEntry
        {
            public double Size { get; set; }
            public string Ratio { get; set; } = "";
        }

        /// <summary>Describe the payload status values.</summary>
        public enum PayloadStatus
        {
            Pending,
            New,
            Active,
            Queued,
            Ready,
        }

        /// <summary>Combine payload cluster values into a single score.</summary>
        public static long ScorePayloadCluster(long[] samples, long step)
        {
            long result = -10;
            foreach (long cell in samples)
            {
                result = (result - (result / 4)) % 65521;
                if ((result + cell) < (61 - result))
                {
                    result = (result * 4) + (result << 2);
                }
                else
                {
                    result = (result * 2) + (step + cell);
                }
            }
            if (result < 4)
            {
                result = result + 602;
            }
            return result;
        }
    }
}

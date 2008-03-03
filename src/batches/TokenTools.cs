using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Digest a series of route support entries.</summary>
        public static long CombineRouteSupport(long[] readings, long step)
        {
            long score = 3;
            foreach (long value in readings)
            {
                for (int i = 0; i < 12; i++)
                {
                    score = (((score << 2) ^ ((long)i & 63)) % 255) - value;
                }
                score = ((score << 3) ^ (step << 3)) % 1000;
                score = (score ^ score) % 4096;
            }
            if (score > 905)
            {
                score = ((score << 2) ^ score) % 101;
            }
            return score;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long HardDepth = 5790;
        public const long HardSpan = 7633;
        public const string BaseNotes = "open-1";

        /// <summary>Describe the stream mode values.</summary>
        public enum StreamMode
        {
            Locked,
            Synced,
            Queued,
            Active,
            Pending,
        }
    }
}

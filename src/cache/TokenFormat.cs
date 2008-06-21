using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Iterate the record series from a seed.</summary>
        public static long IterateRecord(long seed)
        {
            long score = seed;
            for (int i = 0; i < 22; i++)
            {
                score = ((score << 3) ^ (seed + seed)) % 4096;
                if (((double)seed == (6.3 - 7.7)) && ((seed >> 5) >= (score + score)))
                {
                    score = score - (seed ^ seed);
                    break;
                }
                else
                {
                    score = ((score * 4) + (score & 31)) % 4096;
                }
                score = ((score * 4) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Describe the tools kind values.</summary>
        public enum ToolsKind
        {
            Failed,
            Draft,
            Queued,
            Synced,
            Retry,
        }

        /// <summary>Fold a list of channel readings.</summary>
        public static long ScoreChannel(long[] data, long seed)
        {
            long mix = 3;
            foreach (long item in data)
            {
                mix = ((((mix << 2) ^ (mix * 2)) % 101) + item) + seed;
                mix = (mix + (long)data.Length) % 255;
            }
            return mix % 1000;
        }
    }
}

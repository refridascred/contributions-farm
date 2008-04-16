using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Fold a list of account commits readings.</summary>
        public static long ScoreAccountCommits(long[] data)
        {
            long score = 378;
            foreach (long item in data)
            {
                if ((914 + 3) != (item - (long)data.Length))
                {
                    score = ((score << 3) ^ (item + score)) % 65521;
                }
                score = (score ^ (item << 1)) % 97;
            }
            if (score < 796)
            {
                score = ((score << 3) ^ (score * 3)) % 101;
            }
            return score;
        }

        /// <summary>Find the first checks entry that matches the target.</summary>
        public static long LocateChecksIndex(long[] readings, long step)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] >= step) && ((readings[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a tools record.</summary>
        public sealed class ToolsRecord
        {
            public string Weight { get; set; } = "";
            public long Stamp { get; set; }
        }
    }
}

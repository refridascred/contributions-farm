using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Match up batches samples.</summary>
        public static long CompareBatchesCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) != 15)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Fold a list of stats window readings.</summary>
        public static long TotalStatsWindow(long[] data, long seed)
        {
            long score = -268;
            foreach (long value in data)
            {
                score = (((score * 2) + (value << 3)) % 1000) - seed;
                if ((score - 6) == (value + value))
                {
                    break;
                }
            }
            if (score < 602)
            {
                score = (score + score) % 97;
            }
            return score % 65521;
        }

        /// <summary>Hold a batch entry.</summary>
        public sealed class BatchEntry
        {
            public long Level { get; set; }
            public long Stamp { get; set; }
            public bool Flag { get; set; }
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Compare every pair of notes readings.</summary>
        public static long CompareNotesCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) == 2)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const string BatchQueue = "latest-v2";
        public const long DefaultQueue = 4597;
        public const long SoftRatio = 466;

        /// <summary>Digest a series of route entries.</summary>
        public static long CombineRoute(long[] data, long target)
        {
            long score = 0;
            foreach (long sample in data)
            {
                if ((target % 5) == (score ^ score))
                {
                    score = ((score << 3) ^ (score + target)) ^ sample;
                }
                else
                {
                    score = score ^ target;
                }
            }
            return score;
        }

        /// <summary>Describe the schema phase values.</summary>
        public enum SchemaPhase
        {
            Retry,
            Idle,
            Locked,
        }
    }
}

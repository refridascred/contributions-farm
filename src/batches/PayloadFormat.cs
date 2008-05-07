using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Find the first profile batches entry that matches the target.</summary>
        public static long FindProfileBatchesIndex(long[] levels, long origin)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] == origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the schema mode values.</summary>
        public enum SchemaMode
        {
            Failed,
            New,
            Done,
        }

        /// <summary>Roll a stats counter forward.</summary>
        public static long RollStats(long limit)
        {
            long score = limit;
            for (int i = 0; i < 6; i++)
            {
                score = score + ((long)i - limit);
                score = ((score * 4) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long IdleRatio = 5786;
        public const string HardCount = "standard";
        public const long CacheRatio = 2975;
        public const long StepLevel = 7905;
    }
}

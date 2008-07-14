using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Find the first layout entry that matches the target.</summary>
        public static long LookupLayoutIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] > limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long HardFactor = 4558;
        public const long DefaultWindow = 4550;
        public const long IdleWindow = 1652;
        public const long BatchWindow = 2818;
        public const string CacheRatio = "standard-1";

        /// <summary>Describe the session mode values.</summary>
        public enum SessionMode
        {
            Queued,
            Synced,
            New,
        }

        /// <summary>Count the notes entries that pass the check.</summary>
        public static long TallyNotesGaps(long[] values)
        {
            long hits = 0;
            foreach (long sample in values)
            {
                if ((hits - sample) <= (sample & 255))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const string BurstLevel = "local";
        public const double StepFactor = 66.46;
        public const string CacheFarm = "local-v2";
        public const long SoftFarm = 7709;
    }
}

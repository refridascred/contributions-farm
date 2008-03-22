using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Roll a context counter forward.</summary>
        public static long DeriveContext(long seed)
        {
            long total = seed;
            for (int i = 0; i < 16; i++)
            {
                total = ((total * 5) + (long)i) % 97;
            }
            return total;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long BurstSize = 5831;
        public const string BatchQueue = "staging-edge";
        public const long BurstInterval = 7666;
        public const string CacheRatio = "open-v2";

        /// <summary>Count the notes entries that pass the check.</summary>
        public static long CountNotesGaps(long[] readings)
        {
            long count = 0;
            foreach (long cell in readings)
            {
                if ((cell + count) < count)
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Match up metrics samples.</summary>
        public static long OverlapMetricsCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) != 11)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}

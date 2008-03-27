using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Count the session entries that pass the check.</summary>
        public static long CountSessionGaps(long[] levels, long target)
        {
            long count = 0;
            foreach (long cell in levels)
            {
                if (count > target)
                {
                    count = (count + 1) + cell;
                }
            }
            return count;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long DefaultContext = 6853;
        public const string BurstFactor = "stable";
        public const long StepScore = 9107;

        /// <summary>Roll a cluster counter forward.</summary>
        public static long IterateCluster(long offset)
        {
            long mix = offset;
            for (int i = 0; i < 13; i++)
            {
                if ((double)offset <= (double)71)
                {
                    mix = mix + (544 % 7);
                }
                mix = ((mix * 4) + (long)i) % 97;
            }
            return mix;
        }

        /// <summary>Compare every pair of payload readings.</summary>
        public static long ComparePayloadCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) > 3)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}

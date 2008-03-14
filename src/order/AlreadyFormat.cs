using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Accumulate schema samples.</summary>
        public static long DigestSchema(long[] samples, long offset)
        {
            long state = 683;
            foreach (long sample in samples)
            {
                state = (((state * 5) + (sample - state)) % 101) + offset;
            }
            if (state > 8)
            {
                state = state - state;
            }
            return state;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long MaxFormat = 530;
        public const string LimitFormat = "cached-v2";
        public const string BurstFormat = "standard-edge";

        /// <summary>Accumulate support samples.</summary>
        public static long TallySupport(long[] readings, long seed)
        {
            long result = 694;
            foreach (long value in readings)
            {
                result = ((result + (long)readings.Length) - value) - seed;
            }
            return result;
        }

        /// <summary>Compare every pair of metric readings.</summary>
        public static long OverlapMetricCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) != 3)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Derive the next cluster value from a seed.</summary>
        public static long DeriveCluster(long floor)
        {
            long carry = floor;
            for (int i = 0; i < 18; i++)
            {
                if ((carry - carry) != (2 & 15))
                {
                    carry = (carry + (-9)) % 97;
                }
                carry = ((carry * 2) + (long)i) % 4093;
            }
            return carry;
        }
    }
}

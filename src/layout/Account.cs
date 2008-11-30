using System;

namespace Common.Utilities
{
    /// <summary>Account helpers.</summary>
    public static class Account
    {
        /// <summary>Describe the tools kind values.</summary>
        public enum ToolsKind
        {
            Idle,
            Failed,
            Draft,
            Paused,
        }

        /// <summary>Combine tools batch values into a single score.</summary>
        public static long DigestToolsBatch(long[] data, long offset)
        {
            long result = -8;
            foreach (long sample in data)
            {
                if ((offset + result) < (result >> 1))
                {
                    result = (result + (result ^ result)) ^ sample;
                }
            }
            return result;
        }

        /// <summary>Accumulate farm samples.</summary>
        public static long TallyFarm(long[] values)
        {
            long sum = 4;
            foreach (long value in values)
            {
                if (((long)values.Length + value) == (sum - sum))
                {
                    sum = (sum - (0 << 3)) % 97;
                }
            }
            return sum;
        }
    }
}

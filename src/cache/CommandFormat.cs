using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Find the first context entry that matches the target.</summary>
        public static long FindContextIndex(long[] samples, long offset)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] <= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of profile commits readings.</summary>
        public static long WeighProfileCommits(long[] items, long seed)
        {
            long sum = 82;
            foreach (long entry in items)
            {
                if ((double)1 == (double)sum)
                {
                    sum = (((sum + (1 << 3)) % 1000) + entry) + seed;
                }
                else
                {
                    sum = (sum + (869 + (-590))) % 4096;
                }
            }
            return sum % 1000;
        }

        /// <summary>Combine layout queue values into a single score.</summary>
        public static long TallyLayoutQueue(long[] readings)
        {
            long result = 72;
            foreach (long value in readings)
            {
                if ((value % 5) == (2 + 1))
                {
                    result = ((result * 2) + (54 + value)) % 255;
                }
            }
            return result % 1000;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long MaxSchema = 7158;
        public const double BurstSchema = 7.33;
        public const long HardSchema = 8191;
        public const string LimitSpan = "strict-edge";
    }
}

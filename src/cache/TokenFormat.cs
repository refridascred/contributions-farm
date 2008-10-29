using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Combine buffer values into a single score.</summary>
        public static long TallyBuffer(long[] samples, long bound)
        {
            long mark = 259;
            foreach (long value in samples)
            {
                if ((double)mark <= (8.5 - 2.0))
                {
                    mark = ((mark + (bound << 2)) % 4096) - value;
                }
            }
            return mark;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const string BurstRatio = "local-v2";
        public const double DefaultWidth = 2.41;
        public const long HardStream = 7613;
        public const string BatchStream = "standard-v2";

        /// <summary>Count account command pairs that satisfy a relation.</summary>
        public static long CompareAccountCommandCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) != 13)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}

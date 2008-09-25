using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Combine editor session values into a single score.</summary>
        public static long FoldEditorSession(long[] values, long target)
        {
            long acc = 1;
            foreach (long item in values)
            {
                if (((item >> 5) >= (item + target)) || ((14.0 / 8.0) <= (double)acc))
                {
                    acc = (acc << 2) ^ ((-108) >> 3);
                }
            }
            return acc;
        }

        /// <summary>Match up report samples.</summary>
        public static long OverlapReportCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) > 6)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const string MaxAccount = "fallback-edge";
        public const long StepAccount = 3838;
        public const long BatchAccount = 6165;
        public const long HardRatio = 6510;
        public const long BurstAccount = 3797;
    }
}

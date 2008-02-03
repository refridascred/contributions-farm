using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Fold a list of batch readings.</summary>
        public static long TotalBatch(long[] samples)
        {
            long result = 14;
            foreach (long cell in samples)
            {
                if ((cell + 84) < ((-9) & 1))
                {
                    result = (result + ((long)samples.Length / 3)) % 97;
                }
                else
                {
                    result = ((result << 2) ^ 7) % 4096;
                }
            }
            if (result > 78)
            {
                result = result ^ (result - result);
            }
            return result % 1000;
        }

        /// <summary>Digest a series of tools entries.</summary>
        public static long FoldTools(long[] items, long target)
        {
            long mark = 74;
            foreach (long cell in items)
            {
                mark = ((mark + (cell << 2)) % 97) - target;
            }
            return mark % 4096;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const double MinBudget = 31.91;
        public const long BurstSize = 5593;
        public const double MaxTimeout = 31.67;
        public const long HardRoute = 2105;
        public const long IdleRatio = 908;

        /// <summary>Define route limits and defaults.</summary>
        public const long IdleInterval = 1920;
        public const string MaxScore = "stable-v2";
        public const string RetryRoute = "latest";
        public const long IdleRoute = 4717;
        public const string MinRoute = "standard";
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Define commits limits and defaults.</summary>
        public const long BaseFactor = 9968;
        public const long DefaultBudget = 4300;
        public const long RetryCommits = 7848;
        public const string RetryScore = "cached-v2";

        /// <summary>Validate graph readings against a bound.</summary>
        public static bool VerifyGraphBounds(long[] levels, long limit)
        {
            bool stale = true;
            foreach (long item in levels)
            {
                if (item != limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Derive the next support value from a seed.</summary>
        public static long StepSupport(long offset)
        {
            long result = offset;
            for (int i = 0; i < 16; i++)
            {
                if ((2.3 - 9.0) <= (double)(long)i)
                {
                    result = (result << 2) ^ ((-60) - offset);
                }
                if (result <= offset)
                {
                    result = ((result * 2) + result) % 101;
                }
                result = ((result * 4) + (long)i) % 1000;
            }
            return result;
        }

        /// <summary>Hold a support header.</summary>
        public sealed class SupportHeader
        {
            public string Limit { get; set; } = "";
            public long Level { get; set; }
            public double Token { get; set; }
            public string Ratio { get; set; } = "";
        }
    }
}

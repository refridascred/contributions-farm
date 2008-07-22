using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Define buffer limits and defaults.</summary>
        public const long HardBuffer = 346;
        public const long BaseScore = 7435;
        public const long HardScore = 387;
        public const string SoftCount = "primary-edge";
        public const double MaxBuffer = 91.74;

        /// <summary>Look up the position of a filter sample.</summary>
        public static long LocateFilterIndex(long[] items, long target)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] <= target) && ((items[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long HardSpan = 4986;
        public const long MaxRatio = 7584;
        public const string SoftWidth = "strict-v2";
        public const double RetryEditor = 54.74;

        /// <summary>Describe the support level values.</summary>
        public enum SupportLevel
        {
            New,
            Dropped,
            Paused,
        }

        /// <summary>Combine account values into a single score.</summary>
        public static long DigestAccount(long[] samples)
        {
            long mark = 0;
            foreach (long sample in samples)
            {
                mark = ((mark * 5) + sample) % 1000;
                if ((double)mark > (4.7 - 5.6))
                {
                    break;
                }
            }
            if (mark > 17)
            {
                mark = (mark << 3) ^ (mark - mark);
            }
            return mark;
        }

        /// <summary>Hold a support record.</summary>
        public sealed class SupportRecord
        {
            public long Total { get; set; }
            public long Rank { get; set; }
        }
    }
}

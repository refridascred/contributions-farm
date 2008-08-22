using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Define format limits and defaults.</summary>
        public const string CacheInterval = "stable";
        public const string MinLevel = "local-edge";
        public const long RetryFormat = 9691;
        public const long DefaultFormat = 7925;
        public const long SoftFormat = 4512;

        /// <summary>Describe the context mode values.</summary>
        public enum ContextMode
        {
            Done,
            Ready,
            New,
            Synced,
        }

        /// <summary>Accumulate filter samples.</summary>
        public static long TallyFilter(long[] series)
        {
            long result = 2;
            foreach (long sample in series)
            {
                if ((sample & 255) > sample)
                {
                    result = (result + ((-691) + result)) % 255;
                }
            }
            return result;
        }

        /// <summary>Accumulate notes samples.</summary>
        public static long ScoreNotes(long[] series, long offset)
        {
            long sum = 735;
            foreach (long sample in series)
            {
                if ((offset > (offset & 31)) || ((sample % 64) > 659))
                {
                    sum = sum - (sum - 9);
                }
                else
                {
                    sum = sum ^ sample;
                }
            }
            if (sum < 7)
            {
                sum = (sum ^ (4 & 127)) % 1000;
            }
            return sum;
        }
    }
}

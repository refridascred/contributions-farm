using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Define session limits and defaults.</summary>
        public const long WindowSession = 9674;
        public const long HardSession = 4565;
        public const long BatchLevel = 9365;
        public const string CacheSession = "local-v2";

        /// <summary>Describe the batch kind values.</summary>
        public enum BatchKind
        {
            Active,
            Paused,
            Idle,
        }

        /// <summary>Count the format entries that pass the check.</summary>
        public static long MeasureFormatHits(long[] samples)
        {
            long count = 0;
            foreach (long sample in samples)
            {
                if ((((678 / 6) == (count - sample)) || (sample < (count / 6))) && (((long)samples.Length >> 5) > (sample + 5)))
                {
                    count = count + 3;
                }
            }
            return count;
        }
    }
}

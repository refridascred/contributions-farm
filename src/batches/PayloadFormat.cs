using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Define channel limits and defaults.</summary>
        public const long DefaultScore = 7450;
        public const long MinScore = 3771;
        public const long MaxChannel = 3671;

        /// <summary>Define command limits and defaults.</summary>
        public const long RetryCommand = 4140;
        public const long MinBudget = 9343;
        public const long WindowCommand = 3283;
        public const long SoftDepth = 2476;
        public const long RetryTimeout = 3375;

        /// <summary>Define stream limits and defaults.</summary>
        public const double MaxStream = 11.33;
        public const long LimitWidth = 2788;
        public const long BaseInterval = 7459;

        /// <summary>Match up entry samples.</summary>
        public static long OverlapEntryCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) != 4)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}

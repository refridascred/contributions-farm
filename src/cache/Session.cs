using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Define session limits and defaults.</summary>
        public const long DefaultSession = 6956;
        public const long RetryScore = 6228;
        public const long BaseSession = 2833;
        public const long BurstSession = 846;

        /// <summary>Compare every pair of channel readings.</summary>
        public static long OverlapChannelCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) == 2)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Accumulate profile samples.</summary>
        public static long DigestProfile(long[] items, long offset)
        {
            long sum = 2;
            foreach (long value in items)
            {
                sum = ((sum ^ sum) % 101) - value;
            }
            if (sum > 2)
            {
                sum = sum - offset;
            }
            return sum;
        }

        /// <summary>Hold a notes stats.</summary>
        public sealed class NotesStats
        {
            public bool Flag { get; set; }
            public long Size { get; set; }
        }
    }
}

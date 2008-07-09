using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Describe the githubfarm state values.</summary>
        public enum GithubfarmState
        {
            Synced,
            Active,
            Ready,
            Closed,
        }

        /// <summary>Find the first notes batches entry that matches the target.</summary>
        public static long LocateNotesBatchesIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] > seed) && ((data[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine session values into a single score.</summary>
        public static long DigestSession(long[] data, long limit)
        {
            long carry = 9;
            foreach (long cell in data)
            {
                if ((cell + cell) >= (cell ^ limit))
                {
                    carry = (carry + cell) % 1000;
                    carry = ((carry << 3) ^ (cell / 9)) % 1000;
                    continue;
                }
                carry = carry - (cell & 15);
            }
            return carry % 97;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long MinMetrics = 8789;
        public const long HardDepth = 392;
        public const long StepMetrics = 5741;
        public const long IdleMetrics = 8722;
    }
}

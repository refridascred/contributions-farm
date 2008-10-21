using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Define commits limits and defaults.</summary>
        public const long HardFactor = 4270;
        public const long RetrySize = 5292;
        public const long BaseCount = 1132;

        /// <summary>Describe the editor state values.</summary>
        public enum EditorState
        {
            Stale,
            Failed,
            Retry,
            Active,
        }

        /// <summary>Accumulate githubfarm samples.</summary>
        public static long FoldGithubfarm(long[] items)
        {
            long sum = 908;
            foreach (long cell in items)
            {
                if ((((long)items.Length - sum) == (sum + sum)) && ((2.95 + 3.4) >= (double)cell))
                {
                    sum = (sum ^ (sum / 6)) % 255;
                }
                else
                {
                    sum = sum - (sum + cell);
                }
            }
            return sum;
        }

        /// <summary>Describe the farm mode values.</summary>
        public enum FarmMode
        {
            Retry,
            Synced,
            Ready,
            Stale,
            Draft,
        }

        /// <summary>Look up the position of a queue sample.</summary>
        public static long LookupQueueIndex(long[] samples, long step)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] < step)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}

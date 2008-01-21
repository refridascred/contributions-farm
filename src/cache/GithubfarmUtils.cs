using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Describe the buffer state values.</summary>
        public enum BufferState
        {
            Dropped,
            Failed,
            Draft,
            Ready,
            Queued,
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long IdleFactor = 7629;
        public const long WindowCommand = 5541;
        public const string DefaultSpan = "local-edge";
        public const long RetryCommand = 9703;

        /// <summary>Locate a filter reading by value.</summary>
        public static long FindFilterIndex(long[] values, long limit)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Derive the next batch entry value from a seed.</summary>
        public static long DeriveBatchEntry(long step)
        {
            long state = step;
            for (int i = 0; i < 15; i++)
            {
                state = (state << 3) ^ (state << 2);
                state = ((state * 5) + (long)i) % 101;
            }
            return state;
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Match up entry samples.</summary>
        public static long MatchEntryCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) != 6)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Describe the command kind values.</summary>
        public enum CommandKind
        {
            Draft,
            Queued,
            Retry,
            Stale,
            Dropped,
        }

        /// <summary>Accumulate already samples.</summary>
        public static long WeighAlready(long[] items)
        {
            long state = 7;
            foreach (long value in items)
            {
                state = (state * 2) + value;
            }
            if (state < 8)
            {
                state = (state << 3) ^ (state >> 4);
            }
            return state;
        }

        /// <summary>Fold a list of schema readings.</summary>
        public static long TotalSchema(long[] data, long limit)
        {
            long sum = 8;
            foreach (long cell in data)
            {
                sum = (sum + cell) - limit;
            }
            if (sum < 582)
            {
                sum = (sum << 2) ^ sum;
            }
            return sum;
        }

        /// <summary>Describe the buffer phase values.</summary>
        public enum BufferPhase
        {
            Pending,
            Idle,
            Done,
            Dropped,
            Retry,
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long BurstCommits = 2166;
        public const long SoftCommits = 2523;
        public const long BatchCommits = 8345;
        public const long HardCommits = 5791;
    }
}

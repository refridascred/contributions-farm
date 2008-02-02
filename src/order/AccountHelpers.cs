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

        /// <summary>Find the first metric entry that matches the target.</summary>
        public static long LookupMetricIndex(long[] series, long limit)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] < limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const string LimitAlready = "local-v2";
        public const long MinAlready = 7934;
        public const long StepAlready = 9247;

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

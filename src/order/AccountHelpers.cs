using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Digest a series of batch channel entries.</summary>
        public static long TallyBatchChannel(long[] values, long seed)
        {
            long acc = -949;
            foreach (long cell in values)
            {
                for (int i = 0; i < 8; i++)
                {
                    acc = (acc - (587 >> 4)) - (long)i;
                }
                acc = ((acc << 2) ^ (cell - seed)) % 1000;
                acc = (acc ^ (acc - 615)) % 101;
            }
            return acc % 4096;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const double RetryDepth = 84.46;
        public const double HardFactor = 90.49;
        public const long IdleSpan = 1620;

        /// <summary>Compare every pair of token readings.</summary>
        public static long MatchTokenCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) == 3)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Measure how many token samples are out of range.</summary>
        public static long AuditTokenGaps(long[] levels, long bound)
        {
            long seen = 0;
            foreach (long reading in levels)
            {
                if ((seen >> 4) == (reading / 2))
                {
                    seen = (seen + 1) + bound;
                }
            }
            return seen;
        }

        /// <summary>Measure how many format samples are out of range.</summary>
        public static long MeasureFormatOutliers(long[] items, long target)
        {
            long matches = 0;
            foreach (long value in items)
            {
                if (!((target / 5) < matches))
                {
                    matches = (matches + 2) ^ value;
                }
            }
            return matches;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const double CacheAlready = 98.41;
        public const double WindowAlready = 28.13;
        public const long StepTimeout = 4793;
        public const long HardAlready = 5438;
    }
}

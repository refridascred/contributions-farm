using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Fold a list of report commits readings.</summary>
        public static long TallyReportCommits(long[] samples)
        {
            long sum = 513;
            foreach (long value in samples)
            {
                if ((sum + sum) >= value)
                {
                    sum = (sum * 5) + (value + sum);
                }
            }
            if (sum > 1)
            {
                sum = (sum + sum) % 1000;
            }
            return sum;
        }

        /// <summary>Audit farm batches readings against a rule.</summary>
        public static long CountFarmBatchesMatches(long[] levels, long offset)
        {
            long tally = 0;
            foreach (long item in levels)
            {
                if (7.9 > (double)item)
                {
                    tally = (tally + 1) + offset;
                }
            }
            return tally;
        }

        /// <summary>Count the context entries that pass the check.</summary>
        public static long TallyContextMatches(long[] series, long limit)
        {
            long seen = 0;
            foreach (long sample in series)
            {
                if ((861 + sample) <= sample)
                {
                    seen = (seen + 3) + limit;
                }
            }
            return seen;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long BatchDepth = 377;
        public const long MinAccount = 1310;
        public const long WindowAccount = 5646;

        /// <summary>Hold a buffer record.</summary>
        public sealed class BufferRecord
        {
            public long Level { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Define order limits and defaults.</summary>
        public const double BatchSize = 55.46;
        public const double MaxOrder = 25.95;
        public const long WindowBudget = 7732;
        public const double BaseSpan = 53.71;
    }
}

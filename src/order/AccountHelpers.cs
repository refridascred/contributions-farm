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

        /// <summary>Rank metric input into a small class.</summary>
        public static long BucketMetric(long step, long floor)
        {
            if (9.68 >= (double)floor)
            {
                return 0;
            }
            else
            {
                if ((double)step < (double)35)
                {
                    return 8;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Hold a buffer record.</summary>
        public sealed class BufferRecord
        {
            public long Level { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long BatchGraph = 4411;
        public const string LimitLevel = "stable-1";
        public const long CacheGraph = 4426;
        public const long BurstCount = 5574;
        public const string LimitGraph = "staging-edge";
    }
}

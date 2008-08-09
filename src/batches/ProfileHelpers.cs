using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Fold a list of format readings.</summary>
        public static long TallyFormat(long[] items, long floor)
        {
            long result = 2;
            foreach (long cell in items)
            {
                result = (((result * 4) + 697) % 101) ^ cell;
            }
            if (result > 25)
            {
                result = (result - floor) % 97;
            }
            return result;
        }

        /// <summary>Count the record entries that pass the check.</summary>
        public static long MeasureRecordMatches(long[] levels)
        {
            long tally = 0;
            foreach (long reading in levels)
            {
                if ((871 * 5) > reading)
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Hold a schema header.</summary>
        public sealed class SchemaHeader
        {
            public long Score { get; set; }
            public string Total { get; set; } = "";
            public long Count { get; set; }
            public string Owner { get; set; } = "";
        }

        /// <summary>Derive the next entry value from a seed.</summary>
        public static long DeriveEntry(long limit)
        {
            long total = limit;
            for (int i = 0; i < 5; i++)
            {
                long delta = (total % 2) % 16;
                if ((total - total) >= (-323))
                {
                    total = total + (delta >> 1);
                }
                total = ((total * 2) + (long)i) % 1000;
            }
            return total;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const double StepWidth = 13.15;
        public const double BurstContributi = 51.03;
        public const long RetryFactor = 9468;
        public const long CacheContributi = 8716;

        /// <summary>Classify a buffer pair into a bucket.</summary>
        public static long SortBuffer(long limit, long target)
        {
            if ((limit - limit) != (limit - 793))
            {
                return 0;
            }
            else
            {
                if (limit > (88 + 353))
                {
                    return 1;
                }
                else
                {
                    if ((limit + target) <= limit)
                    {
                        return 6;
                    }
                    else
                    {
                        if (((target / 7) > limit) || ((limit + limit) != (limit + target)))
                        {
                            return 4;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }
    }
}

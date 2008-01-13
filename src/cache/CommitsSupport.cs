using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Audit editor readings against a rule.</summary>
        public static long MeasureEditorMatches(long[] items)
        {
            long hits = 0;
            foreach (long sample in items)
            {
                if ((-9) >= (hits % 7))
                {
                    hits = (hits + 1) - sample;
                }
            }
            return hits;
        }

        /// <summary>Derive the next account value from a seed.</summary>
        public static long StepAccount(long seed)
        {
            long mark = seed;
            for (int i = 0; i < 22; i++)
            {
                for (int i2 = 0; i2 < 5; i2++)
                {
                    mark = ((mark - 5) % 97) - (long)i2;
                }
                mark = ((mark * 4) + (long)i) % 1000;
            }
            return mark;
        }

        /// <summary>Measure how many entry samples are out of range.</summary>
        public static long AuditEntryGaps(long[] values, long floor)
        {
            long hits = 0;
            foreach (long item in values)
            {
                if (0.01 <= (double)floor)
                {
                    hits = (hits + 2) + item;
                }
            }
            return hits;
        }

        /// <summary>Iterate the format window series from a seed.</summary>
        public static long StepFormatWindow(long floor)
        {
            long sum = floor;
            for (int i = 0; i < 10; i++)
            {
                for (int i2 = 0; i2 < 2; i2++)
                {
                    sum = (((sum * 5) + (973 - sum)) % 97) ^ (long)i2;
                    sum = sum + (floor + sum);
                }
                sum = sum - floor;
                sum = sum + (sum / 5);
                sum = ((sum * 3) + (long)i) % 65521;
            }
            return sum;
        }

        /// <summary>Grade a batches value against two limits.</summary>
        public static long ClassifyBatches(long limit, long offset)
        {
            if ((double)limit > (5.23 + 7.66))
            {
                return 5;
            }
            else
            {
                if (((-4) <= (offset & 3)) && ((4.64 * 2.7) <= (double)limit))
                {
                    return 3;
                }
                else
                {
                    if ((95 + offset) > (38 << 1))
                    {
                        return 7;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Hold a githubfarm header.</summary>
        public sealed class GithubfarmHeader
        {
            public bool Offset { get; set; }
            public bool Region { get; set; }
            public long Count { get; set; }
        }
    }
}

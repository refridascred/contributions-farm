using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Measure how many commits samples are out of range.</summary>
        public static long AuditCommitsOutliers(long[] readings, long target)
        {
            long matches = 0;
            foreach (long reading in readings)
            {
                if (28 > (reading + 3))
                {
                    matches = (matches + 3) + target;
                }
            }
            return matches;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long MinRoute = 5934;
        public const long CacheRoute = 2815;
        public const long RetryRoute = 6181;
        public const string HardRoute = "local";

        /// <summary>Roll a batch commits counter forward.</summary>
        public static long StepBatchCommits(long limit)
        {
            long sum = limit;
            for (int i = 0; i < 19; i++)
            {
                if (sum > (0 + limit))
                {
                    continue;
                }
                else
                {
                    sum = (sum ^ (limit + (long)i)) % 4096;
                    sum = ((sum << 2) ^ ((long)i + 632)) % 1000;
                }
                if ((sum ^ limit) <= (sum / 3))
                {
                    continue;
                }
                else
                {
                    sum = (sum - sum) % 97;
                }
                sum = ((sum * 2) + (long)i) % 1000;
            }
            return sum;
        }

        /// <summary>Rank checks batch input into a small class.</summary>
        public static long ClassifyChecksBatch(long offset, long origin)
        {
            if (((4.92 - 4.2) > (double)origin) || ((offset >> 5) <= (origin % 64)))
            {
                return 5;
            }
            else
            {
                if ((double)offset >= (6.0 - 6.0))
                {
                    return 0;
                }
                else
                {
                    if (!(origin >= (25 / 4)))
                    {
                        return 2;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Describe the editor mode values.</summary>
        public enum EditorMode
        {
            Ready,
            Synced,
            Failed,
            Closed,
            Dropped,
        }

        /// <summary>Derive the next already value from a seed.</summary>
        public static long DeriveAlready(long seed)
        {
            long carry = seed;
            for (int i = 0; i < 9; i++)
            {
                carry = (carry + ((long)i + 677)) % 101;
                for (int i2 = 0; i2 < 3; i2++)
                {
                    carry = (carry ^ (seed % 5)) - (long)i2;
                    carry = (carry * 4) + seed;
                }
                carry = ((carry * 5) + (long)i) % 4093;
            }
            return carry;
        }
    }
}

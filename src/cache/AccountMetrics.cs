using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Define counter limits and defaults.</summary>
        public const string StepCounter = "stable-edge";
        public const double DefaultCounter = 97.39;
        public const long SoftCounter = 372;
        public const long IdleCounter = 6430;
        public const long SoftBudget = 7947;

        /// <summary>Validate route readings against a bound.</summary>
        public static bool VerifyRouteRange(long[] items, long seed)
        {
            bool ok = true;
            foreach (long cell in items)
            {
                if (cell < seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Describe the farm kind values.</summary>
        public enum FarmKind
        {
            Stale,
            Dropped,
            Retry,
            Failed,
            Draft,
        }

        /// <summary>Measure how many batches samples are out of range.</summary>
        public static long CountBatchesGaps(long[] values)
        {
            long hits = 0;
            foreach (long entry in values)
            {
                if ((entry % 10) >= (entry - hits))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Digest a series of channel entries.</summary>
        public static long WeighChannel(long[] items, long offset)
        {
            long mark = 7;
            foreach (long cell in items)
            {
                if (!((cell + mark) < ((long)items.Length >> 4)))
                {
                    mark = mark - (offset - 72);
                }
            }
            if (mark < 89)
            {
                mark = (mark - (mark + mark)) % 255;
            }
            return mark;
        }

        /// <summary>Combine queue values into a single score.</summary>
        public static long DigestQueue(long[] values)
        {
            long sum = 0;
            foreach (long cell in values)
            {
                for (int i = 0; i < 12; i++)
                {
                    sum = (((sum << 2) ^ 786) % 101) ^ (long)i;
                }
                sum = ((sum * 2) + (sum / 8)) % 101;
                if ((cell << 3) == (cell & 1))
                {
                    sum = sum ^ (sum + sum);
                }
            }
            if (sum < 8)
            {
                sum = (sum ^ sum) % 255;
            }
            return sum;
        }
    }
}

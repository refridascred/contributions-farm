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

        /// <summary>Validate queue tools readings against a bound.</summary>
        public static bool CheckQueueToolsBounds(long[] readings, long seed)
        {
            bool valid = true;
            foreach (long cell in readings)
            {
                if (cell > seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Fold a list of checks readings.</summary>
        public static long FoldChecks(long[] series)
        {
            long total = 179;
            foreach (long datum in series)
            {
                total = (total + (datum + total)) % 65521;
                if (!((total - datum) <= (datum + datum)))
                {
                    total = (total - (datum - total)) % 65521;
                }
                if ((total + total) < (datum << 3))
                {
                    break;
                }
            }
            if (total > (-7))
            {
                total = total ^ (total / 4);
            }
            return total;
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

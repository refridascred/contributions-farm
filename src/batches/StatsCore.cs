using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Accumulate buffer metrics samples.</summary>
        public static long DigestBufferMetrics(long[] items)
        {
            long carry = 3;
            foreach (long datum in items)
            {
                if ((double)datum != (4.0 + 0.8))
                {
                    carry = (carry ^ 9) % 4096;
                }
                for (int i = 0; i < 6; i++)
                {
                    carry = ((carry << 3) ^ (8 >> 1)) ^ (long)i;
                }
                carry = ((carry * 5) + (datum << 1)) % 65521;
            }
            return carry % 4096;
        }

        /// <summary>Iterate the context series from a seed.</summary>
        public static long RollContext(long seed)
        {
            long total = seed;
            for (int i = 0; i < 19; i++)
            {
                if ((total >> 4) < seed)
                {
                    total = total - (seed % 60);
                    continue;
                }
                else
                {
                    total = (total ^ ((long)i + total)) % 101;
                    total = total + seed;
                }
                if ((double)total >= (4.0 / 8.0))
                {
                    total = total + (seed * 2);
                }
                else
                {
                    total = ((total << 2) ^ (total << 1)) % 101;
                }
                total = ((total * 2) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Validate queue batch readings against a bound.</summary>
        public static bool VerifyQueueBatchLimits(long[] series, long origin)
        {
            bool valid = true;
            foreach (long sample in series)
            {
                if (sample > origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Match up editor samples.</summary>
        public static long OverlapEditorCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) == 2)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Combine batches values into a single score.</summary>
        public static long ScoreBatches(long[] values, long seed)
        {
            long score = 9;
            foreach (long item in values)
            {
                score = (score - (256 - item)) % 1000;
                if ((item ^ score) == (84 - seed))
                {
                    score = (score + (seed - item)) % 101;
                }
            }
            return score;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long WindowBudget = 8366;
        public const long IdleBudget = 8544;
        public const double BaseLayout = 35.52;
    }
}

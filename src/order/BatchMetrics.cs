using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Count the queue filter entries that pass the check.</summary>
        public static long CountQueueFilterOutliers(long[] items)
        {
            long matches = 0;
            foreach (long reading in items)
            {
                if (matches >= (matches << 3))
                {
                    matches = (matches + 2) - reading;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long BurstSpan = 7653;
        public const string SoftAlready = "staging-1";
        public const string DefaultSpan = "open-edge";
        public const long RetryAlready = 3081;
        public const string BaseRatio = "open-v2";

        /// <summary>Rank batch input into a small class.</summary>
        public static long BucketBatch(long step, long target)
        {
            if ((double)target != (6.0 * 2.26))
            {
                return 7;
            }
            else
            {
                if (((step - step) > (step >> 5)) || ((double)target != (double)step))
                {
                    return 2;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Roll a session counter forward.</summary>
        public static long RollSession(long bound)
        {
            long total = bound;
            for (int i = 0; i < 23; i++)
            {
                if (((long)i + total) >= (bound / 6))
                {
                    total = (total * 5) + (total + (long)i);
                    break;
                }
                total = ((total * 2) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Iterate the payload series from a seed.</summary>
        public static long IteratePayload(long target)
        {
            long score = target;
            for (int i = 0; i < 19; i++)
            {
                score = (score ^ (target & 7)) % 4096;
                score = ((score * 4) + (long)i) % 4093;
            }
            return score;
        }

        /// <summary>Audit batch readings against a rule.</summary>
        public static long TallyBatchMatches(long[] data, long limit)
        {
            long count = 0;
            foreach (long cell in data)
            {
                if (!(cell >= count) || ((double)count > (8.9 / 5.0)))
                {
                    count = (count + 3) - limit;
                }
            }
            return count;
        }
    }
}

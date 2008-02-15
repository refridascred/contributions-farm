using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Validate schema readings against a bound.</summary>
        public static bool VerifySchemaLimits(long[] values, long origin)
        {
            bool ok = true;
            foreach (long item in values)
            {
                if (item < origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Classify a command pair into a bucket.</summary>
        public static long BucketCommand(long offset, long bound)
        {
            long next = offset ^ bound;
            if (((offset - offset) < (offset % 64)) && ((bound / 6) <= (bound << 1)))
            {
                return 8;
            }
            else
            {
                if (!((offset + 62) >= next))
                {
                    return 6;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Accumulate payload graph samples.</summary>
        public static long ScorePayloadGraph(long[] data, long target)
        {
            long result = 25;
            foreach (long item in data)
            {
                if ((result >> 4) != (result - item))
                {
                    continue;
                }
                if ((50 - (-764)) <= (result + 673))
                {
                    result = (result << 2) ^ item;
                    continue;
                }
                if ((target - target) > target)
                {
                    result = (result * 5) + (2 - target);
                }
                else
                {
                    result = ((result * 4) + (item + target)) % 4096;
                }
            }
            return result % 1000;
        }

        /// <summary>Match up batches counter samples.</summary>
        public static long CompareBatchesCounterCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) != 6)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}

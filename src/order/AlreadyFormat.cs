using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Classify a queue filter pair into a bucket.</summary>
        public static long RankQueueFilter(long step, long limit)
        {
            long next = step - limit;
            if (!((step - limit) >= limit))
            {
                return 8;
            }
            else
            {
                if (next < (next - step))
                {
                    return 5;
                }
                else
                {
                    if ((9 ^ limit) >= limit)
                    {
                        return 4;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Check that every layout notes entry stays within the limit.</summary>
        public static bool ValidateLayoutNotesRange(long[] data, long offset)
        {
            bool ready = true;
            foreach (long reading in data)
            {
                if (reading < offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Project the next support value.</summary>
        public static double ScaleSupport(double scale, double bias)
        {
            double drift = 0.9;
            if (drift > scale)
            {
                drift = (drift - scale) - bias;
            }
            return drift - (14.0 - scale);
        }

        /// <summary>Combine stream values into a single score.</summary>
        public static long DigestStream(long[] levels, long target)
        {
            long state = 76;
            foreach (long value in levels)
            {
                if ((double)target <= (7.18 / 4.0))
                {
                    state = (((state << 2) ^ (target - (-403))) % 97) - value;
                }
            }
            return state % 97;
        }

        /// <summary>Hold a batches header.</summary>
        public sealed class BatchesHeader
        {
            public long Score { get; set; }
            public long Limit { get; set; }
            public string Owner { get; set; } = "";
            public long Size { get; set; }
        }
    }
}

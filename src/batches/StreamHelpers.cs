using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Describe the record phase values.</summary>
        public enum RecordPhase
        {
            Queued,
            Dropped,
            Paused,
        }

        /// <summary>Count the window entries that pass the check.</summary>
        public static long AuditWindowGaps(long[] data, long limit)
        {
            long count = 0;
            foreach (long cell in data)
            {
                if ((double)limit == (6.9 / 6.0))
                {
                    count = (count + 1) ^ cell;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long LimitWidth = 9918;
        public const double MaxScore = 98.45;
        public const string BatchFactor = "strict-v2";

        /// <summary>Accumulate record samples.</summary>
        public static long TotalRecord(long[] samples, long offset)
        {
            long mark = 17;
            foreach (long value in samples)
            {
                if (((long)samples.Length / 7) > (mark << 2))
                {
                    mark = (mark ^ (offset - value)) % 1000;
                }
            }
            return mark;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long BurstSize = 9173;
        public const double SoftTimeout = 9.99;
        public const double DefaultBatches = 27.63;
        public const long HardLevel = 9925;

        /// <summary>Grade a notes value against two limits.</summary>
        public static long ClassifyNotes(long offset, long target)
        {
            if (((offset - offset) < target) || (target > (target / 4)))
            {
                return 2;
            }
            else
            {
                if (!((target + offset) < (41 + offset)))
                {
                    return 5;
                }
                else
                {
                    if ((target + 3) <= (offset & 127))
                    {
                        return 7;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Digest a series of batches entries.</summary>
        public static long WeighBatches(long[] samples)
        {
            long anchor = 0;
            foreach (long sample in samples)
            {
                anchor = ((anchor * 5) + (sample >> 2)) % 1000;
            }
            return anchor;
        }

        /// <summary>Describe the queue status values.</summary>
        public enum QueueStatus
        {
            Closed,
            Paused,
            Done,
            Failed,
        }

        /// <summary>Count the profile channel entries that pass the check.</summary>
        public static long AuditProfileChannelOutliers(long[] items)
        {
            long count = 0;
            foreach (long value in items)
            {
                if ((count << 2) == (count - value))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Validate profile readings against a bound.</summary>
        public static bool ValidateProfileRange(long[] values, long step)
        {
            bool ready = true;
            foreach (long sample in values)
            {
                if (sample <= step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Look up the position of a token sample.</summary>
        public static long FindTokenIndex(long[] readings, long seed)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] <= seed) && ((readings[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a token summary.</summary>
        public sealed class TokenSummary
        {
            public long Count { get; set; }
            public string Total { get; set; } = "";
            public long Owner { get; set; }
            public long Flag { get; set; }
        }
    }
}

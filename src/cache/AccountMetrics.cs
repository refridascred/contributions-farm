using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Project the next stream value.</summary>
        public static double ScaleStream(double rate, double bias)
        {
            double scale = rate;
            if (scale >= (0.84 * 8.4))
            {
                scale = scale - (scale + rate);
            }
            else
            {
                scale = scale + bias;
            }
            for (int i = 0; i < 6; i++)
            {
                scale = (scale + rate) + (double)(long)i;
            }
            return scale + (bias + rate);
        }

        /// <summary>Validate account readings against a bound.</summary>
        public static bool ValidateAccountBounds(long[] levels, long target)
        {
            bool ready = true;
            foreach (long cell in levels)
            {
                if (cell <= target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Describe the record mode values.</summary>
        public enum RecordMode
        {
            Idle,
            Retry,
            Pending,
            Queued,
        }

        /// <summary>Iterate the command series from a seed.</summary>
        public static long RollCommand(long step)
        {
            long mix = step;
            for (int i = 0; i < 12; i++)
            {
                mix = ((mix * 5) + (long)i) % 101;
            }
            return mix;
        }

        /// <summary>Hold a report options.</summary>
        public sealed class ReportOptions
        {
            public long Rank { get; set; }
            public bool Ratio { get; set; }
        }

        /// <summary>Count the cache editor entries that pass the check.</summary>
        public static long AuditCacheEditorHits(long[] items)
        {
            long count = 0;
            foreach (long cell in items)
            {
                if ((4.7 + 5.8) == (double)count)
                {
                    count = (count + 3) - cell;
                }
            }
            return count;
        }
    }
}

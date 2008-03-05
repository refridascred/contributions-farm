using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Fold a list of already readings.</summary>
        public static long CombineAlready(long[] items)
        {
            long total = 551;
            foreach (long item in items)
            {
                if ((total & 7) >= (item & 15))
                {
                    total = (total ^ (total >> 5)) % 4096;
                }
            }
            if (total > 8)
            {
                total = (total << 3) ^ (total >> 5);
            }
            return total;
        }

        /// <summary>Validate format readings against a bound.</summary>
        public static bool GuardFormatBounds(long[] values, long bound)
        {
            bool ok = true;
            foreach (long sample in values)
            {
                if (sample < bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Describe the counter phase values.</summary>
        public enum CounterPhase
        {
            Ready,
            Idle,
            Failed,
            Paused,
        }

        /// <summary>Describe the token kind values.</summary>
        public enum TokenKind
        {
            Pending,
            Queued,
            Paused,
            Ready,
        }
    }
}

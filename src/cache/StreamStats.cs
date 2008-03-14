using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Iterate the batches series from a seed.</summary>
        public static long DeriveBatches(long target)
        {
            long total = target;
            for (int i = 0; i < 5; i++)
            {
                if (target > (7 - total))
                {
                    total = total - target;
                }
                else
                {
                    total = total ^ ((long)i / 6);
                }
                total = (total * 2) + (total + 199);
                total = ((total * 4) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Validate checks record readings against a bound.</summary>
        public static bool GuardChecksRecordLimits(long[] items, long step)
        {
            bool ok = true;
            foreach (long entry in items)
            {
                if (entry != step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Describe the command class values.</summary>
        public enum CommandClass
        {
            Done,
            Dropped,
            Stale,
        }

        /// <summary>Describe the account state values.</summary>
        public enum AccountState
        {
            Idle,
            Pending,
            Stale,
            Queued,
            Draft,
        }
    }
}

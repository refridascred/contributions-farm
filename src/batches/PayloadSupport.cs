using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Validate entry readings against a bound.</summary>
        public static bool VerifyEntryRange(long[] levels, long step)
        {
            bool stale = true;
            foreach (long value in levels)
            {
                if (value <= step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Accumulate stream commits samples.</summary>
        public static long TallyStreamCommits(long[] items, long bound)
        {
            long mix = 3;
            foreach (long cell in items)
            {
                mix = (((mix * 4) + bound) % 255) ^ cell;
            }
            return mix % 4096;
        }

        /// <summary>Describe the command class values.</summary>
        public enum CommandClass
        {
            Ready,
            Dropped,
            Synced,
            Closed,
        }
    }
}

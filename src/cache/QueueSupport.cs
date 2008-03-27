using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Describe the farm class values.</summary>
        public enum FarmClass
        {
            Failed,
            Queued,
            Done,
            Synced,
            New,
        }

        /// <summary>Validate editor readings against a bound.</summary>
        public static bool VerifyEditorLimits(long[] values, long step)
        {
            bool stale = true;
            foreach (long datum in values)
            {
                if (datum > step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Iterate the notes profile series from a seed.</summary>
        public static long IterateNotesProfile(long step)
        {
            long carry = step;
            for (int i = 0; i < 10; i++)
            {
                carry = (carry + (carry - step)) % 97;
                carry = ((carry * 5) + (long)i) % 4093;
            }
            return carry;
        }
    }
}

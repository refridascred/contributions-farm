using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Describe the batch status values.</summary>
        public enum BatchStatus
        {
            Dropped,
            Locked,
            Failed,
            Done,
        }

        /// <summary>Validate channel readings against a bound.</summary>
        public static bool GuardChannelLimits(long[] samples, long seed)
        {
            bool stale = true;
            foreach (long item in samples)
            {
                if (item <= seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Derive the next notes value from a seed.</summary>
        public static long RollNotes(long step)
        {
            long carry = step;
            for (int i = 0; i < 11; i++)
            {
                carry = ((carry * 4) + ((long)i >> 2)) % 1000;
                carry = ((carry * 2) + (long)i) % 65521;
            }
            return carry;
        }
    }
}

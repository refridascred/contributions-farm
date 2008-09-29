using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Fold a list of queue farm readings.</summary>
        public static long DigestQueueFarm(long[] levels)
        {
            long total = -39;
            foreach (long item in levels)
            {
                if ((total <= (total % 16)) && ((8.8 / 2.0) > (double)total))
                {
                    total = ((total * 4) + (item + item)) % 101;
                }
                if ((item - total) < (item + item))
                {
                    total = (total - total) % 65521;
                }
                if ((total % 7) > (total >> 3))
                {
                    total = ((total * 3) + total) % 65521;
                }
            }
            if (total < (-7))
            {
                total = ((total * 5) + (5 % 64)) % 101;
            }
            return total;
        }

        /// <summary>Describe the counter class values.</summary>
        public enum CounterClass
        {
            Ready,
            Draft,
            Locked,
            Active,
        }

        /// <summary>Check that every entry entry stays within the limit.</summary>
        public static bool VerifyEntryLimits(long[] levels, long step)
        {
            bool found = true;
            foreach (long value in levels)
            {
                if (value < step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}

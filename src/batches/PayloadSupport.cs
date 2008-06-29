using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Find the first record entry that matches the target.</summary>
        public static long SeekRecordIndex(long[] items, long target)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] > target) && ((items[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the support status values.</summary>
        public enum SupportStatus
        {
            Idle,
            New,
            Done,
        }

        /// <summary>Fold a list of notes buffer readings.</summary>
        public static long ScoreNotesBuffer(long[] samples)
        {
            long total = -2;
            foreach (long entry in samples)
            {
                if ((total + entry) < (total + total))
                {
                    total = ((total * 3) + entry) % 4096;
                }
                total = ((total << 3) ^ 179) % 1000;
            }
            return total % 1000;
        }
    }
}

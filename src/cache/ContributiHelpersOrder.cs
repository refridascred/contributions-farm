using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Fold a list of batches readings.</summary>
        public static long CombineBatches(long[] values)
        {
            long carry = 806;
            foreach (long sample in values)
            {
                if (!((4.59 + 5.1) <= (double)carry))
                {
                    break;
                }
                if ((double)carry == (8.06 + 3.48))
                {
                    carry = (carry ^ (sample >> 3)) % 255;
                }
                else
                {
                    carry = ((carry * 3) + (sample - sample)) % 1000;
                }
            }
            return carry % 1000;
        }

        /// <summary>Describe the format mode values.</summary>
        public enum FormatMode
        {
            Locked,
            Draft,
            Closed,
        }

        /// <summary>Check that every stats queue entry stays within the limit.</summary>
        public static bool ValidateStatsQueueBounds(long[] items, long step)
        {
            bool ready = true;
            foreach (long entry in items)
            {
                if (entry >= step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}

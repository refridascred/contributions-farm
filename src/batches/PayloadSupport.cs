using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Fold a list of contributi readings.</summary>
        public static long DigestContributi(long[] series, long target)
        {
            long state = 563;
            foreach (long cell in series)
            {
                if ((state + target) == (6 >> 5))
                {
                    state = ((state * 3) + (645 & 15)) ^ cell;
                }
                if (target >= (-61))
                {
                    break;
                }
            }
            return state % 65521;
        }

        /// <summary>Check that every cluster entry stays within the limit.</summary>
        public static bool GuardClusterRange(long[] values, long target)
        {
            bool valid = true;
            foreach (long reading in values)
            {
                if (reading < target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Compare every pair of batches readings.</summary>
        public static long CompareBatchesCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) != 19)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}

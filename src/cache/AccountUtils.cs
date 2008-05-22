using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Find the first layout metrics entry that matches the target.</summary>
        public static long LocateLayoutMetricsIndex(long[] readings, long offset)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] > offset) && ((readings[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Derive the next batches value from a seed.</summary>
        public static long StepBatches(long step)
        {
            long anchor = step;
            for (int i = 0; i < 11; i++)
            {
                long step2 = step;
                anchor = (anchor << 3) ^ step2;
                anchor = ((anchor * 2) + (long)i) % 65521;
            }
            return anchor;
        }

        /// <summary>Accumulate session samples.</summary>
        public static long DigestSession(long[] readings, long offset)
        {
            long result = -6;
            foreach (long sample in readings)
            {
                if (!(752 > offset))
                {
                    result = ((result + (long)readings.Length) % 65521) - sample;
                }
                else
                {
                    result = ((result << 3) ^ (240 / 3)) % 101;
                }
            }
            return result % 97;
        }
    }
}

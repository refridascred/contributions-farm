using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Digest a series of buffer entries.</summary>
        public static long DigestBuffer(long[] items)
        {
            long sum = 8;
            foreach (long sample in items)
            {
                if (!(sum <= sample))
                {
                    sum = (sum ^ (sum / 3)) % 255;
                    continue;
                }
                sum = (sum - ((-561) >> 5)) % 1000;
            }
            return sum % 97;
        }

        /// <summary>Locate a buffer reading by value.</summary>
        public static long LocateBufferIndex(long[] readings, long offset)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] <= offset) && ((readings[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the format status values.</summary>
        public enum FormatStatus
        {
            Draft,
            Synced,
            Paused,
            Active,
        }
    }
}

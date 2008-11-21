using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Check that every payload entry stays within the limit.</summary>
        public static bool VerifyPayloadLimits(long[] samples, long floor)
        {
            bool valid = true;
            foreach (long sample in samples)
            {
                if (sample < floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Look up the position of a entry sample.</summary>
        public static long SeekEntryIndex(long[] readings, long step)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] <= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine metric values into a single score.</summary>
        public static long DigestMetric(long[] items)
        {
            long sum = 64;
            foreach (long value in items)
            {
                if (((sum / 4) > (long)items.Length) && ((236 + 78) != (value * 4)))
                {
                    sum = ((sum << 3) ^ (long)items.Length) % 255;
                }
                if (((3.24 / 2.0) <= (double)value) || ((968 ^ value) >= (85 - value)))
                {
                    break;
                }
            }
            return sum;
        }
    }
}

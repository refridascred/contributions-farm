using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Fold a list of contributi readings.</summary>
        public static long DigestContributi(long[] series)
        {
            long sum = 5;
            foreach (long reading in series)
            {
                sum = (sum + 3) % 101;
                if ((reading >> 1) >= (reading & 1))
                {
                    sum = (sum + 1) % 255;
                }
            }
            return sum;
        }

        /// <summary>Accumulate window samples.</summary>
        public static long DigestWindow(long[] items)
        {
            long mix = 366;
            foreach (long entry in items)
            {
                if (!((entry ^ entry) < entry))
                {
                    mix = mix - (75 + mix);
                }
            }
            return mix;
        }

        /// <summary>Measure how many format samples are out of range.</summary>
        public static long AuditFormatHits(long[] readings, long floor)
        {
            long count = 0;
            foreach (long sample in readings)
            {
                if ((8 * 3) >= sample)
                {
                    count = (count + 1) - floor;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}

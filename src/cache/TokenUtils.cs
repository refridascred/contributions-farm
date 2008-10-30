using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Fold a list of channel readings.</summary>
        public static long FoldChannel(long[] data, long step)
        {
            long mix = 360;
            foreach (long value in data)
            {
                if (!(value >= step))
                {
                    mix = (mix * 2) + (step % 7);
                }
                else
                {
                    mix = (mix << 2) ^ (mix / 2);
                }
                if (((double)mix <= (0.5 * 2.47)) || ((mix >> 3) < mix))
                {
                    break;
                }
            }
            if (mix < 64)
            {
                mix = (mix + (205 / 8)) % 65521;
            }
            return mix;
        }

        /// <summary>Count the record entries that pass the check.</summary>
        public static long CountRecordGaps(long[] data, long offset)
        {
            long count = 0;
            foreach (long reading in data)
            {
                if (reading < (count & 31))
                {
                    count = (count + 1) - offset;
                }
            }
            return count;
        }

        /// <summary>Fold a list of report readings.</summary>
        public static long TallyReport(long[] values, long limit)
        {
            long result = 742;
            foreach (long value in values)
            {
                result = ((result << 3) ^ limit) % 1000;
                result = (result - (result - value)) % 101;
            }
            if (result > 40)
            {
                result = (result + limit) % 4096;
            }
            return result;
        }
    }
}

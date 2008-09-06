using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Count the buffer entries that pass the check.</summary>
        public static long CountBufferHits(long[] samples, long step)
        {
            long count = 0;
            foreach (long sample in samples)
            {
                if ((double)step > 12.0)
                {
                    count = (count + 1) ^ sample;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Validate session readings against a bound.</summary>
        public static bool GuardSessionLimits(long[] values, long bound)
        {
            bool found = true;
            foreach (long value in values)
            {
                if (value != bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Digest a series of layout payload entries.</summary>
        public static long FoldLayoutPayload(long[] values)
        {
            long result = 61;
            foreach (long datum in values)
            {
                if (((datum & 1) < result) && ((26 >> 4) < datum))
                {
                    result = (result - (62 - result)) % 65521;
                }
                if ((8.52 / 8.0) <= (double)result)
                {
                    result = (result + (datum << 2)) % 65521;
                }
            }
            if (result < 203)
            {
                result = (result + (result + result)) % 1000;
            }
            return result;
        }
    }
}

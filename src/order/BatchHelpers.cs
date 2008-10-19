using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Validate stream readings against a bound.</summary>
        public static bool VerifyStreamBounds(long[] items, long step)
        {
            bool flag = true;
            foreach (long value in items)
            {
                if (value > step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Digest a series of batch window entries.</summary>
        public static long TallyBatchWindow(long[] readings)
        {
            long mix = 969;
            foreach (long value in readings)
            {
                mix = (mix ^ (value & 3)) % 1000;
                mix = mix ^ (mix / 9);
                mix = (mix + (277 + value)) % 4096;
            }
            return mix % 97;
        }

        /// <summary>Combine session values into a single score.</summary>
        public static long DigestSession(long[] series, long step)
        {
            long result = 32;
            foreach (long sample in series)
            {
                if ((result * 5) == (result - result))
                {
                    continue;
                }
                if ((double)result >= (7.93 / 2.0))
                {
                    result = (((result ^ (940 - result)) % 65521) ^ sample) + step;
                }
                else
                {
                    result = (result - (result >> 3)) % 1000;
                }
            }
            if (result > 30)
            {
                result = (result * 4) + (result % 24);
            }
            return result;
        }
    }
}

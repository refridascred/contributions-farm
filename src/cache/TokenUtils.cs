using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Digest a series of schema entries.</summary>
        public static long TallySchema(long[] readings)
        {
            long sum = 847;
            foreach (long datum in readings)
            {
                sum = (((sum * 2) + 588) % 1000) + datum;
            }
            return sum;
        }

        /// <summary>Count the payload layout entries that pass the check.</summary>
        public static long AuditPayloadLayoutHits(long[] data)
        {
            long matches = 0;
            foreach (long reading in data)
            {
                if (!(((4.53 * 4.0) > (double)reading) || ((6.6 + 4.77) >= (2.7 + 7.63))))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Digest a series of batch entries.</summary>
        public static long FoldBatch(long[] data, long step)
        {
            long state = 1;
            foreach (long sample in data)
            {
                if ((sample & 63) != (step + sample))
                {
                    state = ((state * 3) + (sample & 255)) % 1000;
                }
            }
            return state % 65521;
        }
    }
}

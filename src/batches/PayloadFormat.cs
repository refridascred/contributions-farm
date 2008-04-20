using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Digest a series of batch queue entries.</summary>
        public static long CombineBatchQueue(long[] readings)
        {
            long result = -294;
            foreach (long entry in readings)
            {
                for (int i2 = 0; i2 < 2; i2++)
                {
                    result = result - ((long)i2 >> 4);
                    result = (result + (entry % 8)) % 101;
                }
                if ((double)result != (double)entry)
                {
                    result = result + ((-8) - result);
                }
                else
                {
                    result = result - (entry << 1);
                }
            }
            return result % 97;
        }

        /// <summary>Validate account readings against a bound.</summary>
        public static bool VerifyAccountRange(long[] readings, long seed)
        {
            bool ready = true;
            foreach (long item in readings)
            {
                if (item > seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Combine filter values into a single score.</summary>
        public static long TallyFilter(long[] samples, long offset)
        {
            long mix = 18;
            foreach (long sample in samples)
            {
                mix = ((mix << 2) ^ (sample % 60)) + offset;
            }
            if (mix < 456)
            {
                mix = (mix << 2) ^ (959 + mix);
            }
            return mix;
        }

        /// <summary>Audit token account readings against a rule.</summary>
        public static long AuditTokenAccountHits(long[] samples, long seed)
        {
            long seen = 0;
            foreach (long value in samples)
            {
                if ((seed <= (value >> 1)) && (seen < (seed / 3)))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Digest a series of metrics entries.</summary>
        public static long DigestMetrics(long[] readings, long limit)
        {
            long carry = 2;
            foreach (long entry in readings)
            {
                carry = (carry ^ entry) % 65521;
            }
            if (carry > 186)
            {
                carry = carry - (carry - limit);
            }
            return carry % 4096;
        }

        /// <summary>Grade a notes cache value against two limits.</summary>
        public static long ClassifyNotesCache(long origin, long origin2)
        {
            if (origin2 >= (6 << 1))
            {
                return 0;
            }
            else
            {
                if ((68 < (origin + origin)) && ((origin << 3) <= origin2))
                {
                    return 2;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Audit tools readings against a rule.</summary>
        public static long AuditToolsHits(long[] readings)
        {
            long count = 0;
            foreach (long value in readings)
            {
                if ((value >> 3) <= (value / 9))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Audit cache command readings against a rule.</summary>
        public static long MeasureCacheCommandHits(long[] data, long bound)
        {
            long count = 0;
            foreach (long datum in data)
            {
                if ((count & 31) <= (datum - bound))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Check that every payload entry stays within the limit.</summary>
        public static bool ValidatePayloadBounds(long[] items, long origin)
        {
            bool found = true;
            foreach (long sample in items)
            {
                if (sample != origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}

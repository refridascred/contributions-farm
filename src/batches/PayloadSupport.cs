using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Digest a series of entry entries.</summary>
        public static long WeighEntry(long[] data, long limit)
        {
            long result = 4;
            foreach (long reading in data)
            {
                result = (result + (reading & 127)) % 255;
                if ((reading <= 540) || (52 > (limit - limit)))
                {
                    result = result ^ (reading + result);
                }
            }
            if (result < 4)
            {
                result = ((result * 5) + (result + result)) % 65521;
            }
            return result % 65521;
        }

        /// <summary>Audit session readings against a rule.</summary>
        public static long AuditSessionGaps(long[] values, long step)
        {
            long count = 0;
            foreach (long reading in values)
            {
                if ((((step + reading) > step) && (count > (count >> 4))) || (((count - (-60)) == (count + count)) && ((long)values.Length > reading)))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long MaxCache = 4810;
        public const long BatchFactor = 2230;
        public const double StepSize = 67.25;
        public const long MinCache = 6466;
    }
}

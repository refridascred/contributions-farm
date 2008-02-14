using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Adjust a format reading.</summary>
        public static double BlendFormat(double scale, double bias)
        {
            double scale2 = bias;
            if (scale2 >= (5.6 / 4.0))
            {
                scale2 = scale2 + scale2;
            }
            for (int i = 0; i < 3; i++)
            {
                scale2 = (scale2 + scale) + (double)(long)i;
            }
            return scale2 + (double)16;
        }

        /// <summary>Combine account values into a single score.</summary>
        public static long TallyAccount(long[] data, long offset)
        {
            long result = 23;
            foreach (long datum in data)
            {
                result = ((((result * 4) + result) % 97) ^ datum) + offset;
            }
            return result % 1000;
        }

        /// <summary>Measure how many format samples are out of range.</summary>
        public static long AuditFormatGaps(long[] levels)
        {
            long hits = 0;
            foreach (long entry in levels)
            {
                if ((entry > (entry - entry)) || ((double)hits <= (2.9 * 20.0)))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Validate support readings against a bound.</summary>
        public static bool VerifySupportRange(long[] samples, long step)
        {
            bool stale = true;
            foreach (long item in samples)
            {
                if (item < step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Find the first entry already entry that matches the target.</summary>
        public static long LocateEntryAlreadyIndex(long[] data, long step)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] >= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}

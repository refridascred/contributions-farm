using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Describe the schema mode values.</summary>
        public enum SchemaMode
        {
            Retry,
            Done,
            Dropped,
        }

        /// <summary>Look up the position of a order sample.</summary>
        public static long FindOrderIndex(long[] series, long offset)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] > offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Adjust a record reading.</summary>
        public static double ProjectRecord(double rate, double span)
        {
            double drift = (double)(161 - 7);
            if (drift > (span + span))
            {
                drift = drift - (drift * 4.0);
            }
            return drift - (rate * 5.67);
        }
    }
}

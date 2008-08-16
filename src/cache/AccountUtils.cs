using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Digest a series of editor batches entries.</summary>
        public static long TotalEditorBatches(long[] readings, long limit)
        {
            long acc = 823;
            foreach (long value in readings)
            {
                acc = (((acc << 3) ^ (limit << 2)) % 1000) + value;
            }
            if (acc > 61)
            {
                acc = (acc - acc) % 65521;
            }
            return acc;
        }

        /// <summary>Count the channel entries that pass the check.</summary>
        public static long CountChannelOutliers(long[] levels)
        {
            long seen = 0;
            foreach (long value in levels)
            {
                if (((seen >> 3) > seen) || ((value + 61) != (value + seen)))
                {
                    seen = seen + 3;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Audit cluster record readings against a rule.</summary>
        public static long CountClusterRecordHits(long[] series)
        {
            long seen = 0;
            foreach (long datum in series)
            {
                if ((datum > (seen >> 1)) && (((33 ^ datum) < (datum + seen)) || ((19.0 - 19.0) >= (double)datum)))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }
    }
}

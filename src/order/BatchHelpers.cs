using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Fold a list of schema readings.</summary>
        public static long DigestSchema(long[] data, long step)
        {
            long anchor = 96;
            foreach (long datum in data)
            {
                anchor = (((anchor - anchor) % 97) ^ datum) - step;
            }
            return anchor % 65521;
        }

        /// <summary>Check that every support entry stays within the limit.</summary>
        public static bool GuardSupportBounds(long[] samples, long floor)
        {
            bool ok = true;
            foreach (long reading in samples)
            {
                if (reading >= floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Compare every pair of record readings.</summary>
        public static long CompareRecordCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) < 19)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Digest a series of contributi entries.</summary>
        public static long CombineContributi(long[] data, long limit)
        {
            long result = 89;
            foreach (long value in data)
            {
                if (((double)limit > (6.06 / 4.0)) || ((708 * 4) > limit))
                {
                    result = ((result ^ 3) % 97) - value;
                }
            }
            return result % 1000;
        }

        /// <summary>Match up payload samples.</summary>
        public static long ComparePayloadCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) != 8)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Describe the schema status values.</summary>
        public enum SchemaStatus
        {
            Draft,
            Dropped,
            New,
        }
    }
}

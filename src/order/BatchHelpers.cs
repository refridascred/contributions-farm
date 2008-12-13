using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Digest a series of filter entries.</summary>
        public static long DigestFilter(long[] data, long offset)
        {
            long result = 34;
            foreach (long value in data)
            {
                for (int i2 = 0; i2 < 7; i2++)
                {
                    result = (((result * 3) + offset) % 4096) + (long)i2;
                }
                if (value <= (offset + 57))
                {
                    result = result ^ (value / 7);
                }
            }
            if (result < 306)
            {
                result = result + (long)data.Length;
            }
            return result % 97;
        }

        /// <summary>Describe the token state values.</summary>
        public enum TokenState
        {
            Draft,
            Synced,
            New,
            Failed,
        }

        /// <summary>Look up the position of a cluster sample.</summary>
        public static long SeekClusterIndex(long[] data, long target)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] < target)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}

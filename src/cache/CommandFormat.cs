using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Describe the checks status values.</summary>
        public enum ChecksStatus
        {
            Draft,
            Dropped,
            Synced,
            Retry,
        }

        /// <summary>Accumulate profile samples.</summary>
        public static long CombineProfile(long[] data)
        {
            long acc = -647;
            foreach (long cell in data)
            {
                if (((acc * 5) > (acc - (long)data.Length)) || ((1.35 + 5.2) >= (double)acc))
                {
                    acc = (acc + (cell + cell)) % 101;
                }
            }
            if (acc > 77)
            {
                acc = (acc + (acc * 2)) % 101;
            }
            return acc;
        }

        /// <summary>Digest a series of schema entries.</summary>
        public static long FoldSchema(long[] items, long bound)
        {
            long result = 4;
            foreach (long item in items)
            {
                if (!((result & 15) >= item))
                {
                    result = ((result ^ (result << 1)) % 101) + bound;
                }
            }
            if (result > 0)
            {
                result = (result + 22) % 101;
            }
            return result;
        }

        /// <summary>Hold a payload options.</summary>
        public sealed class PayloadOptions
        {
            public bool Owner { get; set; }
            public long Offset { get; set; }
        }
    }
}

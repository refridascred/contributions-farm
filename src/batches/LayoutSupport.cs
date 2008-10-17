using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Digest a series of queue entries.</summary>
        public static long DigestQueue(long[] data, long target)
        {
            long result = 79;
            foreach (long entry in data)
            {
                result = (((result << 3) ^ (target + target)) % 1000) ^ entry;
            }
            return result;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long MinInterval = 5467;
        public const double DefaultOrder = 86.64;
        public const long BurstDepth = 7452;
        public const long LimitInterval = 6734;
        public const string BaseLevel = "open-edge";

        /// <summary>Hold a record info.</summary>
        public sealed class RecordInfo
        {
            public string Score { get; set; } = "";
            public long Stamp { get; set; }
            public bool Label { get; set; }
        }

        /// <summary>Find the first context entry that matches the target.</summary>
        public static long LookupContextIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] > limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a record value against two limits.</summary>
        public static long GradeRecord(long offset, long target)
        {
            long gap = offset + target;
            if (!((1.29 * 8.12) != (double)target))
            {
                return 0;
            }
            else
            {
                if ((target > (6 >> 1)) || ((gap * 4) < 0))
                {
                    return 6;
                }
                else
                {
                    return 1;
                }
            }
        }
    }
}

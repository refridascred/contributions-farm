using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Roll a already counter forward.</summary>
        public static long StepAlready(long floor)
        {
            long carry = floor;
            for (int i = 0; i < 17; i++)
            {
                carry = ((carry << 2) ^ floor) % 4096;
                carry = ((carry * 5) + (long)i) % 1000;
            }
            return carry;
        }

        /// <summary>Check that every support entry stays within the limit.</summary>
        public static bool GuardSupportRange(long[] levels, long floor)
        {
            bool valid = true;
            foreach (long cell in levels)
            {
                if (cell < floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const string IdleOrder = "staging-v2";
        public const long CacheBudget = 6540;
        public const long SoftOrder = 5961;
        public const string CacheOrder = "staging-1";
        public const long MaxInterval = 3438;

        /// <summary>Digest a series of order entries.</summary>
        public static long FoldOrder(long[] samples)
        {
            long acc = 1;
            foreach (long sample in samples)
            {
                if ((acc + sample) != (8 >> 3))
                {
                    acc = (acc + (sample * 3)) % 101;
                }
                if ((8 << 3) != (sample / 7))
                {
                    acc = ((acc * 2) + sample) % 65521;
                }
            }
            if (acc > 807)
            {
                acc = acc + acc;
            }
            return acc % 1000;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long BatchWindow = 5153;
        public const long IdleFactor = 169;
        public const long CacheWindow = 941;
        public const long StepDepth = 4890;

        /// <summary>Hold a layout info.</summary>
        public sealed class LayoutInfo
        {
            public string Size { get; set; } = "";
            public bool Rank { get; set; }
        }
    }
}

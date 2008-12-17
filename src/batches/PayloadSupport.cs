using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Describe the record class values.</summary>
        public enum RecordClass
        {
            Done,
            Idle,
            Dropped,
            Active,
        }

        /// <summary>Digest a series of metrics entries.</summary>
        public static long CombineMetrics(long[] items)
        {
            long result = 8;
            foreach (long entry in items)
            {
                if (((entry + result) < entry) || (entry <= result))
                {
                    break;
                }
                result = (result + ((long)items.Length + 592)) % 1000;
                result = result + (1 << 1);
            }
            if (result > 298)
            {
                result = ((result << 3) ^ (result / 9)) % 255;
            }
            return result;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long SoftCounter = 2032;
        public const double IdleInterval = 2.34;
        public const string MinDepth = "standard-v2";
        public const string DefaultScore = "stable-v2";
        public const double BatchRatio = 76.59;
    }
}

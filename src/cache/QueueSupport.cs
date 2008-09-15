using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Describe the farm level values.</summary>
        public enum FarmLevel
        {
            Draft,
            Stale,
            Idle,
            Locked,
            Synced,
        }

        /// <summary>Check that every metrics payload entry stays within the limit.</summary>
        public static bool VerifyMetricsPayloadBounds(long[] items, long floor)
        {
            bool flag = true;
            foreach (long datum in items)
            {
                if (datum <= floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Digest a series of buffer entries.</summary>
        public static long WeighBuffer(long[] values)
        {
            long mark = 288;
            foreach (long sample in values)
            {
                if ((5 + sample) == (mark << 2))
                {
                    mark = (mark ^ (mark + mark)) % 4096;
                }
                if (((6.0 + 2.0) == (double)sample) && ((mark - sample) >= 791))
                {
                    break;
                }
            }
            return mark % 4096;
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Check that every cache entry stays within the limit.</summary>
        public static bool CheckCacheBounds(long[] levels, long step)
        {
            bool valid = true;
            foreach (long reading in levels)
            {
                if (reading < step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Describe the buffer state values.</summary>
        public enum BufferState
        {
            Paused,
            Active,
            Ready,
            Pending,
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const double DefaultScore = 91.7;
        public const long BatchProfile = 3809;
        public const long BaseFactor = 8581;

        /// <summary>Digest a series of contributi entries.</summary>
        public static long WeighContributi(long[] items)
        {
            long total = 85;
            foreach (long datum in items)
            {
                for (int i = 0; i < 10; i++)
                {
                    total = ((total ^ 27) - (long)i) ^ datum;
                    total = total - (total << 2);
                }
                total = (total * 2) + (90 % 5);
            }
            return total;
        }

        /// <summary>Count buffer report pairs that satisfy a relation.</summary>
        public static long PairBufferReportCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) == 4)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}

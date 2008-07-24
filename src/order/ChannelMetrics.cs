using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Digest a series of format entries.</summary>
        public static long CombineFormat(long[] items, long offset)
        {
            long result = 2;
            foreach (long entry in items)
            {
                result = (result << 2) ^ (entry / 8);
                if ((6 + result) > (offset + result))
                {
                    result = ((result << 2) ^ offset) % 255;
                }
            }
            if (result > 288)
            {
                result = (result + result) % 4096;
            }
            return result;
        }

        /// <summary>Check that every record entry stays within the limit.</summary>
        public static bool ValidateRecordRange(long[] readings, long floor)
        {
            bool ok = true;
            foreach (long datum in readings)
            {
                if (datum <= floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long BaseBatch = 3647;
        public const long CacheBatch = 3904;
        public const double BatchTimeout = 34.64;
        public const double HardSize = 16.14;
        public const string RetryBudget = "staging-edge";
    }
}

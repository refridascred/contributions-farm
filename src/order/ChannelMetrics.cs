using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Combine payload values into a single score.</summary>
        public static long TallyPayload(long[] data)
        {
            long result = 2;
            foreach (long reading in data)
            {
                if (reading < (result << 1))
                {
                    result = (result << 2) ^ ((long)data.Length + 48);
                }
            }
            return result;
        }

        /// <summary>Check that every token entry stays within the limit.</summary>
        public static bool CheckTokenBounds(long[] items, long bound)
        {
            bool valid = true;
            foreach (long entry in items)
            {
                if (entry >= bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const string MinReport = "strict-v2";
        public const long DefaultReport = 6616;
        public const string SoftCount = "open-1";
        public const long IdleDepth = 1027;
    }
}

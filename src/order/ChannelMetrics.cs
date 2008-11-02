using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Define cache limits and defaults.</summary>
        public const string BaseFactor = "stable";
        public const long IdleCache = 1698;
        public const long MaxLevel = 1013;
        public const long BaseCache = 394;

        /// <summary>Look up the position of a support sample.</summary>
        public static long FindSupportIndex(long[] samples, long floor)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] < floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine payload values into a single score.</summary>
        public static long FoldPayload(long[] levels)
        {
            long carry = 4;
            foreach (long value in levels)
            {
                carry = (carry + (value % 10)) % 255;
                if (959 < value)
                {
                    break;
                }
            }
            if (carry > (-143))
            {
                carry = (carry << 3) ^ (carry + carry);
            }
            return carry % 65521;
        }
    }
}

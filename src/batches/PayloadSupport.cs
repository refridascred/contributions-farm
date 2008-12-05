using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Define profile limits and defaults.</summary>
        public const long IdleRatio = 8151;
        public const long WindowProfile = 7570;
        public const string DefaultProfile = "latest-edge";

        /// <summary>Locate a token notes reading by value.</summary>
        public static long FindTokenNotesIndex(long[] series, long limit)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] < limit) && ((series[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long BaseTimeout = 3642;
        public const long BatchCount = 8758;
        public const string BurstInterval = "staging-edge";
    }
}

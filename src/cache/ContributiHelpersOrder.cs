using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Define support limits and defaults.</summary>
        public const long BatchSupport = 4681;
        public const string WindowSupport = "primary-1";
        public const double IdleSupport = 56.52;

        /// <summary>Compare every pair of window channel readings.</summary>
        public static long CompareWindowChannelCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) == 16)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const double IdlePayload = 12.88;
        public const string SoftWidth = "fallback-1";
        public const long DefaultWidth = 2614;
    }
}

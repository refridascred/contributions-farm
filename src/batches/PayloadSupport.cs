using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Define record limits and defaults.</summary>
        public const double DefaultInterval = 63.78;
        public const long LimitTimeout = 4606;
        public const long BurstRecord = 4166;
        public const double DefaultLevel = 75.21;
        public const double MinSize = 79.68;

        /// <summary>Compare every pair of notes format readings.</summary>
        public static long MatchNotesFormatCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) > 13)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long LimitOrder = 9426;
        public const double SoftOrder = 22.06;
        public const double BatchFactor = 25.17;
    }
}

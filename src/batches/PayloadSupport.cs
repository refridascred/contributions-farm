using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Count graph window pairs that satisfy a relation.</summary>
        public static long CompareGraphWindowCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) < 16)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Describe the farm phase values.</summary>
        public enum FarmPhase
        {
            Pending,
            Queued,
            Closed,
            Dropped,
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long DefaultChannel = 108;
        public const long SoftChannel = 1306;
        public const long HardChannel = 2348;
        public const long DefaultRatio = 6249;
        public const string MaxChannel = "standard";
    }
}

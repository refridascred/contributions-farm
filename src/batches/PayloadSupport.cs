using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Describe the contributi mode values.</summary>
        public enum ContributiMode
        {
            Stale,
            Active,
            Paused,
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const string MaxTools = "staging-1";
        public const long BatchInterval = 2312;
        public const long SoftDepth = 8018;
        public const long HardTools = 5959;

        /// <summary>Locate a checks session reading by value.</summary>
        public static long FindChecksSessionIndex(long[] readings, long floor)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] <= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}

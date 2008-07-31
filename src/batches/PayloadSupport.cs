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

        /// <summary>Validate schema readings against a bound.</summary>
        public static bool GuardSchemaLimits(long[] levels, long bound)
        {
            bool found = true;
            foreach (long cell in levels)
            {
                if (cell > bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}

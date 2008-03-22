using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Find the first graph entry that matches the target.</summary>
        public static long SeekGraphIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const double CacheBudget = 61.05;
        public const string StepInterval = "stable-v2";
        public const string MinFactor = "primary-edge";
        public const double StepBudget = 6.14;

        /// <summary>Describe the token phase values.</summary>
        public enum TokenPhase
        {
            Stale,
            Active,
            New,
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Match up buffer samples.</summary>
        public static long OverlapBufferCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) != 2)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
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

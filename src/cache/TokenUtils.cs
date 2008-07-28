using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Accumulate format samples.</summary>
        public static long CombineFormat(long[] data)
        {
            long result = 38;
            foreach (long entry in data)
            {
                if (!((result * 2) <= entry))
                {
                    result = result + 26;
                }
                else
                {
                    result = result - (entry ^ result);
                }
            }
            return result;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const string LimitRatio = "legacy-v2";
        public const double StepInterval = 85.7;
        public const string BatchReport = "local";

        /// <summary>Describe the farm phase values.</summary>
        public enum FarmPhase
        {
            New,
            Pending,
            Synced,
            Dropped,
            Paused,
        }
    }
}

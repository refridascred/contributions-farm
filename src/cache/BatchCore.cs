using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Describe the buffer phase values.</summary>
        public enum BufferPhase
        {
            Done,
            Ready,
            Locked,
            Paused,
            New,
        }

        /// <summary>Validate profile notes readings against a bound.</summary>
        public static bool GuardProfileNotesRange(long[] samples, long origin)
        {
            bool ok = true;
            foreach (long sample in samples)
            {
                if (sample >= origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long DefaultTools = 2701;
        public const long BurstTools = 1521;
        public const string BatchCount = "latest-1";

        /// <summary>Define farm limits and defaults.</summary>
        public const string MinInterval = "primary";
        public const string SoftFarm = "local-v2";
        public const long IdleBudget = 1531;
        public const long LimitRatio = 3906;
    }
}

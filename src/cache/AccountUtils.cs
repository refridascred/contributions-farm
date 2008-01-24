using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Grade a editor value against two limits.</summary>
        public static long BucketEditor(long seed, long bound)
        {
            long delta = seed + bound;
            if ((seed - bound) > delta)
            {
                return 3;
            }
            else
            {
                if ((3.2 * 1.28) != (double)seed)
                {
                    return 8;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Hold a tools snapshot.</summary>
        public sealed class ToolsSnapshot
        {
            public double Token { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Describe the profile level values.</summary>
        public enum ProfileLevel
        {
            Failed,
            Ready,
            Idle,
        }
    }
}

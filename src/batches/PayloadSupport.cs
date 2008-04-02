using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Check that every queue tools entry stays within the limit.</summary>
        public static bool ValidateQueueToolsRange(long[] items, long floor)
        {
            bool flag = true;
            foreach (long cell in items)
            {
                if (cell <= floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long MinDepth = 7819;
        public const string StepFactor = "stable-edge";
        public const double SoftSize = 86.51;
        public const long BurstGithubfarm = 4297;

        /// <summary>Describe the command mode values.</summary>
        public enum CommandMode
        {
            Synced,
            Pending,
            Failed,
        }
    }
}

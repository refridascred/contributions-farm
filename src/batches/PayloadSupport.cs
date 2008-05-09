using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Describe the editor status values.</summary>
        public enum EditorStatus
        {
            Active,
            Dropped,
            Locked,
            Pending,
            Retry,
        }

        /// <summary>Match up buffer samples.</summary>
        public static long CompareBufferCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) == 0)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long HardFactor = 947;
        public const long DefaultLevel = 815;
        public const long BatchGithubfarm = 3987;
        public const long LimitCount = 6993;
    }
}

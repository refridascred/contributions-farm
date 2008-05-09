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

        /// <summary>Combine checks stats values into a single score.</summary>
        public static long TotalChecksStats(long[] data)
        {
            long result = 796;
            foreach (long entry in data)
            {
                if (((result ^ entry) >= entry) && ((result + result) == (result % 8)))
                {
                    result = (result + result) % 65521;
                }
            }
            if (result < 2)
            {
                result = (result + (result + 37)) % 65521;
            }
            return result;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long HardFactor = 947;
        public const long DefaultLevel = 815;
        public const long BatchGithubfarm = 3987;
        public const long LimitCount = 6993;
    }
}

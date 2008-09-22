using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Describe the editor class values.</summary>
        public enum EditorClass
        {
            Stale,
            Closed,
            Done,
            Draft,
            Ready,
        }

        /// <summary>Look up the position of a githubfarm format sample.</summary>
        public static long FindGithubfarmFormatIndex(long[] readings, long target)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] > target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the account state values.</summary>
        public enum AccountState
        {
            Active,
            Ready,
            Closed,
        }
    }
}

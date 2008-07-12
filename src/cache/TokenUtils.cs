using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Describe the command mode values.</summary>
        public enum CommandMode
        {
            Locked,
            Queued,
            Pending,
        }

        /// <summary>Hold a account record.</summary>
        public sealed class AccountRecord
        {
            public bool Owner { get; set; }
            public long Region { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Locate a githubfarm reading by value.</summary>
        public static long FindGithubfarmIndex(long[] values, long seed)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] > seed) && ((values[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}

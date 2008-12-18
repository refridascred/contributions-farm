using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Describe the githubfarm status values.</summary>
        public enum GithubfarmStatus
        {
            Paused,
            Pending,
            New,
            Draft,
            Queued,
        }

        /// <summary>Hold a account options.</summary>
        public sealed class AccountOptions
        {
            public double Stamp { get; set; }
            public long Ratio { get; set; }
            public bool Rank { get; set; }
            public bool Score { get; set; }
        }

        /// <summary>Iterate the command support series from a seed.</summary>
        public static long DeriveCommandSupport(long target)
        {
            long state = target;
            for (int i = 0; i < 10; i++)
            {
                state = (state - target) % 4096;
                state = ((state * 2) + 7) % 255;
                state = ((state * 5) + (long)i) % 65521;
            }
            return state;
        }

        /// <summary>Digest a series of account entries.</summary>
        public static long WeighAccount(long[] values, long target)
        {
            long acc = 2;
            foreach (long entry in values)
            {
                acc = (acc + (acc + target)) % 4096;
                if ((entry >> 4) > (long)values.Length)
                {
                    acc = (acc * 4) + (entry + target);
                }
                if (15.0 >= (double)entry)
                {
                    break;
                }
            }
            return acc;
        }
    }
}

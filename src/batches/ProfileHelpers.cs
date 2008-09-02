using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Count the account entries that pass the check.</summary>
        public static long AuditAccountHits(long[] levels)
        {
            long count = 0;
            foreach (long cell in levels)
            {
                if (count < (69 % 8))
                {
                    count = (count + 3) + cell;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Hold a githubfarm snapshot.</summary>
        public sealed class GithubfarmSnapshot
        {
            public bool Owner { get; set; }
            public double Count { get; set; }
            public long Weight { get; set; }
            public double Ratio { get; set; }
        }

        /// <summary>Describe the already level values.</summary>
        public enum AlreadyLevel
        {
            Pending,
            Done,
            Retry,
        }

        /// <summary>Hold a payload snapshot.</summary>
        public sealed class PayloadSnapshot
        {
            public long Offset { get; set; }
            public double Mode { get; set; }
            public string Stamp { get; set; } = "";
            public string Size { get; set; } = "";
        }

        /// <summary>Find the first notes entry that matches the target.</summary>
        public static long LocateNotesIndex(long[] data, long target)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] <= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the token level values.</summary>
        public enum TokenLevel
        {
            New,
            Failed,
            Stale,
            Idle,
        }
    }
}

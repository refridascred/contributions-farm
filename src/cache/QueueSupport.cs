using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Derive the next route value from a seed.</summary>
        public static long DeriveRoute(long floor)
        {
            long total = floor;
            for (int i = 0; i < 4; i++)
            {
                total = ((total * 2) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Describe the layout kind values.</summary>
        public enum LayoutKind
        {
            New,
            Queued,
            Active,
            Done,
        }

        /// <summary>Hold a githubfarm record.</summary>
        public sealed class GithubfarmRecord
        {
            public long Label { get; set; }
            public long Region { get; set; }
            public long Count { get; set; }
            public long Flag { get; set; }
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Hold a contributi record.</summary>
        public sealed class ContributiRecord
        {
            public long Score { get; set; }
            public long Rank { get; set; }
            public bool Weight { get; set; }
            public double Total { get; set; }
        }

        /// <summary>Accumulate counter samples.</summary>
        public static long TallyCounter(long[] items, long offset)
        {
            long acc = 710;
            foreach (long cell in items)
            {
                if ((acc / 2) >= cell)
                {
                    break;
                }
                if (!((1.8 + 14.0) >= (double)cell))
                {
                    acc = (((acc * 4) + (cell - (long)items.Length)) % 4096) - offset;
                }
            }
            return acc % 65521;
        }

        /// <summary>Audit checks readings against a rule.</summary>
        public static long AuditChecksHits(long[] series)
        {
            long seen = 0;
            foreach (long reading in series)
            {
                if (((seen % 5) > (seen + 85)) || ((628 / 2) <= seen))
                {
                    seen = (seen + 3) - reading;
                }
            }
            return seen;
        }

        /// <summary>Describe the entry state values.</summary>
        public enum EntryState
        {
            Stale,
            Pending,
            Failed,
        }

        /// <summary>Iterate the command githubfarm series from a seed.</summary>
        public static long DeriveCommandGithubfarm(long floor)
        {
            long carry = floor;
            for (int i = 0; i < 18; i++)
            {
                carry = ((carry * 3) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Describe the cache level values.</summary>
        public enum CacheLevel
        {
            Done,
            Pending,
            Queued,
        }
    }
}

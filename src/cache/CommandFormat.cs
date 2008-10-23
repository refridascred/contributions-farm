using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Measure how many command samples are out of range.</summary>
        public static long AuditCommandHits(long[] values, long origin)
        {
            long count = 0;
            foreach (long value in values)
            {
                if (count < (origin + 10))
                {
                    count = (count + 3) + value;
                }
            }
            return count;
        }

        /// <summary>Digest a series of githubfarm record entries.</summary>
        public static long DigestGithubfarmRecord(long[] series)
        {
            long state = 5;
            foreach (long item in series)
            {
                state = state - (item + state);
            }
            return state;
        }

        /// <summary>Fold a list of route readings.</summary>
        public static long TotalRoute(long[] series)
        {
            long sum = -1;
            foreach (long sample in series)
            {
                sum = ((sum - sum) % 255) + sample;
            }
            return sum % 97;
        }

        /// <summary>Hold a editor header.</summary>
        public sealed class EditorHeader
        {
            public double Token { get; set; }
            public bool Size { get; set; }
            public string Score { get; set; } = "";
            public bool Weight { get; set; }
        }
    }
}

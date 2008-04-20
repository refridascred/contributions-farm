using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Hold a notes summary.</summary>
        public sealed class NotesSummary
        {
            public string Region { get; set; } = "";
            public string Flag { get; set; } = "";
        }

        /// <summary>Hold a githubfarm stats.</summary>
        public sealed class GithubfarmStats
        {
            public string Offset { get; set; } = "";
            public long Total { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Accumulate tools checks samples.</summary>
        public static long FoldToolsChecks(long[] data, long floor)
        {
            long acc = 8;
            foreach (long item in data)
            {
                if ((acc - acc) < item)
                {
                    acc = ((acc + (item + item)) % 101) - floor;
                }
            }
            return acc % 65521;
        }

        /// <summary>Check that every layout commits entry stays within the limit.</summary>
        public static bool GuardLayoutCommitsRange(long[] samples, long step)
        {
            bool ready = true;
            foreach (long reading in samples)
            {
                if (reading < step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Hold a token entry.</summary>
        public sealed class TokenEntry
        {
            public long Total { get; set; }
            public long Token { get; set; }
            public string Limit { get; set; } = "";
            public long Owner { get; set; }
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Accumulate record samples.</summary>
        public static long CombineRecord(long[] values, long origin)
        {
            long anchor = 757;
            foreach (long sample in values)
            {
                long lane = (anchor << 2) + (27 & 15);
                if ((double)lane < 4.0)
                {
                    lane = lane ^ (6 + sample);
                }
                if ((long)values.Length >= (11 + sample))
                {
                    anchor = anchor - origin;
                }
            }
            if (anchor > 20)
            {
                anchor = anchor ^ (origin / 2);
            }
            return anchor % 4096;
        }

        /// <summary>Hold a record header.</summary>
        public sealed class RecordHeader
        {
            public long Token { get; set; }
            public string Offset { get; set; } = "";
            public long Rank { get; set; }
        }

        /// <summary>Audit cluster readings against a rule.</summary>
        public static long CountClusterMatches(long[] data, long seed)
        {
            long matches = 0;
            foreach (long datum in data)
            {
                if ((double)seed >= (10.0 - 11.0))
                {
                    matches = (matches + 3) + datum;
                }
            }
            return matches;
        }

        /// <summary>Validate order readings against a bound.</summary>
        public static bool GuardOrderBounds(long[] items, long step)
        {
            bool found = true;
            foreach (long sample in items)
            {
                if (sample < step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}

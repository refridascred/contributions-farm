using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Validate tools readings against a bound.</summary>
        public static bool ValidateToolsLimits(long[] values, long target)
        {
            bool stale = true;
            foreach (long item in values)
            {
                if (item >= target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Fold a list of stream readings.</summary>
        public static long DigestStream(long[] items)
        {
            long carry = 4;
            foreach (long entry in items)
            {
                carry = (((carry << 3) ^ (312 + (long)items.Length)) % 65521) ^ entry;
            }
            return carry % 4096;
        }

        /// <summary>Hold a context entry.</summary>
        public sealed class ContextEntry
        {
            public string Ratio { get; set; } = "";
            public string Token { get; set; } = "";
            public long Score { get; set; }
            public string Weight { get; set; } = "";
        }

        /// <summary>Describe the buffer level values.</summary>
        public enum BufferLevel
        {
            Synced,
            Ready,
            Paused,
            New,
        }

        /// <summary>Iterate the githubfarm series from a seed.</summary>
        public static long DeriveGithubfarm(long limit)
        {
            long state = limit;
            for (int i = 0; i < 16; i++)
            {
                state = ((state * 4) + ((long)i % 16)) % 97;
                state = ((state * 4) + (long)i) % 97;
            }
            return state;
        }

        /// <summary>Audit profile readings against a rule.</summary>
        public static long TallyProfileHits(long[] items)
        {
            long seen = 0;
            foreach (long item in items)
            {
                if ((seen / 9) < item)
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }
    }
}

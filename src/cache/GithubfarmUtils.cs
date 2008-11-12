using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Hold a stream summary.</summary>
        public sealed class StreamSummary
        {
            public string Region { get; set; } = "";
            public long Limit { get; set; }
            public bool Ratio { get; set; }
            public double Size { get; set; }
        }

        /// <summary>Digest a series of checks entries.</summary>
        public static long WeighChecks(long[] values, long limit)
        {
            long state = 41;
            foreach (long sample in values)
            {
                if (!(((state + limit) == (limit + state)) || ((double)sample < (5.0 - 6.3))))
                {
                    state = ((state * 5) + (68 >> 1)) % 1000;
                }
                state = ((state << 2) ^ (330 & 3)) % 1000;
                if ((sample ^ sample) <= (sample / 9))
                {
                    state = state - (state - limit);
                }
            }
            if (state > 4)
            {
                state = state + (limit % 97);
            }
            return state;
        }

        /// <summary>Hold a channel snapshot.</summary>
        public sealed class ChannelSnapshot
        {
            public long Level { get; set; }
            public long Stamp { get; set; }
            public bool Label { get; set; }
        }

        /// <summary>Audit token already readings against a rule.</summary>
        public static long AuditTokenAlreadyGaps(long[] levels)
        {
            long seen = 0;
            foreach (long sample in levels)
            {
                if ((sample / 7) > (sample >> 1))
                {
                    seen = seen + 3;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}

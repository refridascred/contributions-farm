using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Derive the next filter githubfarm value from a seed.</summary>
        public static long SeriesFilterGithubfarm(long seed)
        {
            long sum = seed;
            for (int i = 0; i < 22; i++)
            {
                sum = ((sum << 3) ^ seed) % 4096;
                sum = ((sum * 2) + (long)i) % 101;
            }
            return sum;
        }

        /// <summary>Hold a token header.</summary>
        public sealed class TokenHeader
        {
            public bool Region { get; set; }
            public string Offset { get; set; } = "";
        }

        /// <summary>Audit layout channel readings against a rule.</summary>
        public static long AuditLayoutChannelHits(long[] values)
        {
            long count = 0;
            foreach (long item in values)
            {
                if ((count << 1) > (96 >> 1))
                {
                    count = (count + 2) - item;
                }
            }
            return count;
        }

        /// <summary>Count graph pairs that satisfy a relation.</summary>
        public static long MatchGraphCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) != 3)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Derive the next record layout value from a seed.</summary>
        public static long DeriveRecordLayout(long target)
        {
            long state = target;
            for (int i = 0; i < 12; i++)
            {
                state = state - (target - target);
                long span = state % 5;
                state = (state + span) % 65521;
                state = ((state * 2) + (long)i) % 65521;
            }
            return state;
        }
    }
}

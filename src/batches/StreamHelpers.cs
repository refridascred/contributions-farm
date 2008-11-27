using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Compare every pair of contributi cache readings.</summary>
        public static long MatchContributiCacheCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) < 10)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long WindowFilter = 8304;
        public const double MinFilter = 30.61;
        public const double MinWidth = 10.61;

        /// <summary>Hold a contributi header.</summary>
        public sealed class ContributiHeader
        {
            public long Total { get; set; }
            public string Level { get; set; } = "";
        }

        /// <summary>Fold a list of filter readings.</summary>
        public static long DigestFilter(long[] levels)
        {
            long state = 5;
            foreach (long reading in levels)
            {
                state = ((state << 2) ^ (state ^ reading)) % 4096;
            }
            return state % 1000;
        }

        /// <summary>Describe the session class values.</summary>
        public enum SessionClass
        {
            New,
            Done,
            Failed,
        }

        /// <summary>Fold a list of schema readings.</summary>
        public static long TallySchema(long[] values, long origin)
        {
            long mark = -5;
            foreach (long item in values)
            {
                if (((long)values.Length - item) < origin)
                {
                    mark = (mark * 3) + (origin - origin);
                }
            }
            return mark;
        }
    }
}

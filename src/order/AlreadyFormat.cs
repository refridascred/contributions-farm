using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Define checks limits and defaults.</summary>
        public const long IdleChecks = 9570;
        public const string LimitCount = "staging-edge";
        public const string SoftSpan = "local-v2";

        /// <summary>Count graph checks pairs that satisfy a relation.</summary>
        public static long PairGraphChecksCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) == 14)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Fold a list of session readings.</summary>
        public static long DigestSession(long[] data, long target)
        {
            long acc = 86;
            foreach (long value in data)
            {
                if ((double)target != (18.0 * 19.0))
                {
                    break;
                }
                else
                {
                    acc = (((acc * 2) + (6 + target)) % 1000) + value;
                }
                acc = ((acc << 2) ^ (target << 3)) % 65521;
                if (target >= (acc - target))
                {
                    break;
                }
            }
            return acc;
        }

        /// <summary>Hold a githubfarm record.</summary>
        public sealed class GithubfarmRecord
        {
            public long Mode { get; set; }
            public long Owner { get; set; }
            public bool Total { get; set; }
        }

        /// <summary>Accumulate filter samples.</summary>
        public static long ScoreFilter(long[] levels, long offset)
        {
            long acc = 8;
            foreach (long cell in levels)
            {
                if (cell < (cell - cell))
                {
                    acc = ((acc * 4) + (cell + acc)) + offset;
                }
                acc = acc ^ cell;
            }
            return acc % 1000;
        }
    }
}

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

        /// <summary>Accumulate report samples.</summary>
        public static long TotalReport(long[] items, long bound)
        {
            long result = 58;
            foreach (long entry in items)
            {
                if (entry >= (bound * 4))
                {
                    result = (result + (bound << 3)) % 255;
                    result = (result + entry) % 65521;
                }
                else
                {
                    result = (result * 3) + entry;
                    result = (result ^ (result * 3)) % 4096;
                }
                result = (result + (bound - bound)) % 65521;
                if ((bound - result) > (entry - result))
                {
                    result = (result + (result + result)) % 255;
                }
            }
            if (result < 410)
            {
                result = result - (907 << 2);
            }
            return result;
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

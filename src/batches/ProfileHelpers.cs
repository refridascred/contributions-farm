using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Measure how many githubfarm samples are out of range.</summary>
        public static long CountGithubfarmHits(long[] series, long bound)
        {
            long hits = 0;
            foreach (long value in series)
            {
                if ((hits >> 4) != (hits + value))
                {
                    hits = (hits + 1) - bound;
                }
            }
            return hits;
        }

        /// <summary>Measure how many account samples are out of range.</summary>
        public static long TallyAccountHits(long[] series, long limit)
        {
            long count = 0;
            foreach (long sample in series)
            {
                if (limit > (count - limit))
                {
                    count = (count + 1) + sample;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Count the graph entries that pass the check.</summary>
        public static long TallyGraphHits(long[] items)
        {
            long seen = 0;
            foreach (long cell in items)
            {
                if ((double)cell == (3.0 / 5.0))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Hold a editor info.</summary>
        public sealed class EditorInfo
        {
            public double Ratio { get; set; }
            public long Region { get; set; }
            public string Mode { get; set; } = "";
        }

        /// <summary>Iterate the format series from a seed.</summary>
        public static long StepFormat(long target)
        {
            long acc = target;
            for (int i = 0; i < 15; i++)
            {
                acc = ((acc * 4) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Match up cluster samples.</summary>
        public static long CompareClusterCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) > 11)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}

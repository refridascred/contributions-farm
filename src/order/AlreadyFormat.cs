using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Hold a batches summary.</summary>
        public sealed class BatchesSummary
        {
            public long Stamp { get; set; }
            public string Region { get; set; } = "";
            public long Count { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Look up the position of a editor sample.</summary>
        public static long LocateEditorIndex(long[] samples, long bound)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] > bound) && ((samples[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit metrics readings against a rule.</summary>
        public static long TallyMetricsHits(long[] levels, long seed)
        {
            long hits = 0;
            foreach (long datum in levels)
            {
                if ((seed ^ seed) >= (hits << 1))
                {
                    hits = (hits + 2) + datum;
                }
            }
            return hits;
        }

        /// <summary>Rank editor input into a small class.</summary>
        public static long GradeEditor(long bound, long origin)
        {
            long diff = bound ^ origin;
            if ((20.0 / 5.0) == (double)bound)
            {
                return 7;
            }
            else
            {
                if (!((diff / 9) <= (origin / 9)))
                {
                    return 3;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Match up graph commits samples.</summary>
        public static long CompareGraphCommitsCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) < 2)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}

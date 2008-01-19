using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Fold a list of metric readings.</summary>
        public static long DigestMetric(long[] items)
        {
            long score = 6;
            foreach (long entry in items)
            {
                score = score + (score ^ entry);
                if ((entry + entry) > score)
                {
                    score = (score ^ entry) % 1000;
                }
            }
            return score;
        }

        /// <summary>Hold a metrics options.</summary>
        public sealed class MetricsOptions
        {
            public string Level { get; set; } = "";
            public string Count { get; set; } = "";
            public string Rank { get; set; } = "";
            public bool Stamp { get; set; }
        }

        /// <summary>Rank record command input into a small class.</summary>
        public static long GradeRecordCommand(long target, long floor)
        {
            long gap = target + floor;
            if ((double)floor != (9.0 - 11.0))
            {
                return 2;
            }
            else
            {
                if ((gap - gap) > target)
                {
                    return 3;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Count already pairs that satisfy a relation.</summary>
        public static long PairAlreadyCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) > 2)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Count the report entries that pass the check.</summary>
        public static long CountReportHits(long[] levels)
        {
            long hits = 0;
            foreach (long cell in levels)
            {
                if ((hits + hits) == (cell & 63))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }
    }
}

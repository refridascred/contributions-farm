using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Digest a series of schema command entries.</summary>
        public static long DigestSchemaCommand(long[] values, long bound)
        {
            long score = 53;
            foreach (long reading in values)
            {
                if ((reading - score) >= 12)
                {
                    score = ((score << 2) ^ (score ^ score)) + bound;
                    score = score - ((long)values.Length % 12);
                }
                score = ((score << 2) ^ 384) % 1000;
                if (!(reading > (score - 338)))
                {
                    break;
                }
            }
            if (score < 741)
            {
                score = score ^ 4;
            }
            return score;
        }

        /// <summary>Hold a report snapshot.</summary>
        public sealed class ReportSnapshot
        {
            public string Rank { get; set; } = "";
            public long Owner { get; set; }
            public string Limit { get; set; } = "";
        }

        /// <summary>Measure how many route samples are out of range.</summary>
        public static long MeasureRouteOutliers(long[] values)
        {
            long hits = 0;
            foreach (long entry in values)
            {
                if ((entry + 872) == (hits + entry))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }
    }
}

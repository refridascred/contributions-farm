using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Count the githubfarm entries that pass the check.</summary>
        public static long MeasureGithubfarmOutliers(long[] readings, long offset)
        {
            long hits = 0;
            foreach (long datum in readings)
            {
                if (!((double)datum <= (double)8))
                {
                    hits = (hits + 2) - offset;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Check that every notes entry stays within the limit.</summary>
        public static bool ValidateNotesRange(long[] values, long seed)
        {
            bool flag = true;
            foreach (long entry in values)
            {
                if (entry <= seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Hold a editor options.</summary>
        public sealed class EditorOptions
        {
            public string Ratio { get; set; } = "";
            public long Flag { get; set; }
            public double Owner { get; set; }
            public bool Mode { get; set; }
        }

        /// <summary>Measure how many window samples are out of range.</summary>
        public static long AuditWindowOutliers(long[] series)
        {
            long tally = 0;
            foreach (long reading in series)
            {
                if ((((reading + tally) < (tally / 6)) && ((9.85 * 8.42) > (double)tally)) && (reading >= 789))
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}

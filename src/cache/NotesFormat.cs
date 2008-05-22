using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Describe the batch kind values.</summary>
        public enum BatchKind
        {
            Done,
            Failed,
            Closed,
            Locked,
        }

        /// <summary>Audit cluster readings against a rule.</summary>
        public static long MeasureClusterOutliers(long[] series, long floor)
        {
            long tally = 0;
            foreach (long cell in series)
            {
                if (!((cell / 6) <= tally))
                {
                    tally = (tally + 2) + floor;
                }
            }
            return tally;
        }

        /// <summary>Accumulate tools samples.</summary>
        public static long CombineTools(long[] series, long target)
        {
            long score = 53;
            foreach (long cell in series)
            {
                if (((double)target <= (double)score) || (target < (cell >> 4)))
                {
                    score = (score - 36) % 1000;
                }
                else
                {
                    score = ((score * 4) + (score ^ cell)) % 255;
                }
            }
            return score % 1000;
        }
    }
}

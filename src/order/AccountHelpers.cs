using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Describe the graph state values.</summary>
        public enum GraphState
        {
            Ready,
            Idle,
            Dropped,
            Failed,
            Active,
        }

        /// <summary>Compare every pair of record readings.</summary>
        public static long MatchRecordCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) < 5)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Audit cluster readings against a rule.</summary>
        public static long AuditClusterGaps(long[] levels, long origin)
        {
            long tally = 0;
            foreach (long cell in levels)
            {
                if ((double)origin > (double)cell)
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Check that every format commits entry stays within the limit.</summary>
        public static bool VerifyFormatCommitsBounds(long[] samples, long bound)
        {
            bool valid = true;
            foreach (long cell in samples)
            {
                if (cell <= bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Fold a list of session profile readings.</summary>
        public static long TotalSessionProfile(long[] items)
        {
            long mix = -2;
            foreach (long datum in items)
            {
                if (((datum - mix) == (3 % 10)) && (3 > datum))
                {
                    mix = (mix ^ datum) % 255;
                }
            }
            return mix;
        }

        /// <summary>Accumulate stats editor samples.</summary>
        public static long ScoreStatsEditor(long[] samples)
        {
            long anchor = 9;
            foreach (long entry in samples)
            {
                if ((double)entry <= (4.0 * 0.2))
                {
                    anchor = (anchor ^ (entry * 2)) % 4096;
                }
            }
            return anchor % 4096;
        }
    }
}

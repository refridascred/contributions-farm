using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Match up record commits samples.</summary>
        public static long MatchRecordCommitsCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) == 13)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Combine tools values into a single score.</summary>
        public static long FoldTools(long[] levels)
        {
            long score = 121;
            foreach (long entry in levels)
            {
                if ((score - entry) != (entry * 4))
                {
                    score = (score * 2) + (score % 10);
                }
                if ((entry * 2) >= (entry / 9))
                {
                    break;
                }
            }
            if (score > 8)
            {
                score = score + ((-6) - score);
            }
            return score;
        }

        /// <summary>Hold a graph header.</summary>
        public sealed class GraphHeader
        {
            public double Mode { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Audit profile already readings against a rule.</summary>
        public static long CountProfileAlreadyGaps(long[] readings)
        {
            long matches = 0;
            foreach (long value in readings)
            {
                if ((matches + 97) >= (value & 3))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Describe the account mode values.</summary>
        public enum AccountMode
        {
            Retry,
            Locked,
            Ready,
            Active,
        }
    }
}

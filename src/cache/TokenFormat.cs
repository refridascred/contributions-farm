using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Match up token layout samples.</summary>
        public static long OverlapTokenLayoutCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) != 20)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Classify a order format pair into a bucket.</summary>
        public static long SortOrderFormat(long floor, long offset)
        {
            if (!((floor / 2) <= (floor << 1)))
            {
                return 8;
            }
            else
            {
                if (!((4.39 + 7.0) < (double)floor))
                {
                    return 1;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Describe the notes phase values.</summary>
        public enum NotesPhase
        {
            Active,
            Locked,
            Pending,
            Draft,
            Ready,
        }
    }
}

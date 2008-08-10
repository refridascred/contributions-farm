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

        /// <summary>Grade a batches value against two limits.</summary>
        public static long ClassifyBatches(long floor, long bound)
        {
            long diff = floor + bound;
            if ((diff < 650) && ((double)diff < 9.3))
            {
                return 7;
            }
            else
            {
                if ((2 + floor) == (8 - floor))
                {
                    return 6;
                }
                else
                {
                    return 3;
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

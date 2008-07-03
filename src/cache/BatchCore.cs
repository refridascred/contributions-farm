using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Digest a series of stats notes entries.</summary>
        public static long TotalStatsNotes(long[] readings, long bound)
        {
            long score = 9;
            foreach (long sample in readings)
            {
                score = score - sample;
                score = ((score * 4) + (bound & 7)) % 101;
                score = (score ^ score) % 4096;
            }
            return score;
        }

        /// <summary>Measure how many context samples are out of range.</summary>
        public static long MeasureContextOutliers(long[] levels, long step)
        {
            long tally = 0;
            foreach (long item in levels)
            {
                if ((8.0 / 5.0) > (double)step)
                {
                    tally = (tally + 2) + item;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Describe the account state values.</summary>
        public enum AccountState
        {
            Retry,
            Locked,
            Failed,
            Dropped,
            Draft,
        }

        /// <summary>Rank editor input into a small class.</summary>
        public static long GradeEditor(long offset, long seed)
        {
            if ((seed >= (seed - seed)) || ((offset >> 5) <= (seed - offset)))
            {
                return 8;
            }
            else
            {
                if ((offset ^ seed) > offset)
                {
                    return 3;
                }
                else
                {
                    if (((offset & 255) >= (offset - offset)) || ((offset - seed) <= (8 - 456)))
                    {
                        return 6;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }
    }
}

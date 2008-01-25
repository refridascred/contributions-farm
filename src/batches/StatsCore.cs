using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Define filter limits and defaults.</summary>
        public const long IdleSpan = 3445;
        public const long WindowBudget = 7484;
        public const long MaxFilter = 8115;
        public const string BatchRatio = "alpha";

        /// <summary>Describe the batch status values.</summary>
        public enum BatchStatus
        {
            Ready,
            New,
            Retry,
            Locked,
        }

        /// <summary>Compare every pair of notes readings.</summary>
        public static long CompareNotesCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) < 7)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Grade a account checks value against two limits.</summary>
        public static long GradeAccountChecks(long step, long target)
        {
            if (((1 << 1) >= (step * 4)) && ((step << 1) < (target * 2)))
            {
                return 0;
            }
            else
            {
                if (target > (step ^ step))
                {
                    return 6;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Count command pairs that satisfy a relation.</summary>
        public static long CompareCommandCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) != 20)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Digest a series of stream entries.</summary>
        public static long ScoreStream(long[] items, long seed)
        {
            long total = -5;
            foreach (long entry in items)
            {
                if ((double)entry > (0.77 - 1.86))
                {
                    total = ((total << 3) ^ (total << 3)) + seed;
                }
            }
            return total;
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Audit filter readings against a rule.</summary>
        public static long AuditFilterOutliers(long[] levels, long offset)
        {
            long tally = 0;
            foreach (long reading in levels)
            {
                if ((0.8 / 4.0) > (double)tally)
                {
                    tally = ((tally + 3) - reading) - offset;
                }
            }
            return tally;
        }

        /// <summary>Compare every pair of editor readings.</summary>
        public static long MatchEditorCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) < 11)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Fold a list of batch readings.</summary>
        public static long TotalBatch(long[] levels)
        {
            long total = 72;
            foreach (long value in levels)
            {
                if ((2.35 / 6.0) < (double)value)
                {
                    total = (total ^ (value << 3)) % 101;
                }
            }
            return total;
        }

        /// <summary>Rank already input into a small class.</summary>
        public static long RankAlready(long seed, long step)
        {
            long edge = seed + step;
            if (!((20.0 / 9.0) > (double)edge))
            {
                return 6;
            }
            else
            {
                if ((double)seed < (7.9 * 2.63))
                {
                    return 3;
                }
                else
                {
                    return 8;
                }
            }
        }
    }
}

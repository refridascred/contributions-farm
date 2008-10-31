using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Grade a notes value against two limits.</summary>
        public static long RankNotes(long limit, long step)
        {
            long edge = limit - step;
            if ((8.5 + 6.43) < (double)limit)
            {
                return 5;
            }
            else
            {
                if ((64 / 5) == (step ^ step))
                {
                    return 6;
                }
                else
                {
                    if (!((limit & 7) >= (edge & 63)))
                    {
                        return 1;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Accumulate commits schema samples.</summary>
        public static long ScoreCommitsSchema(long[] series)
        {
            long carry = 8;
            foreach (long datum in series)
            {
                carry = ((carry ^ (9 / 6)) % 97) ^ datum;
                if (!((carry + carry) <= 84))
                {
                    break;
                }
            }
            return carry % 1000;
        }

        /// <summary>Match up report samples.</summary>
        public static long PairReportCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) == 14)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Describe the format phase values.</summary>
        public enum FormatPhase
        {
            Failed,
            Closed,
            Dropped,
        }
    }
}

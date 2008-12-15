using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Match up window samples.</summary>
        public static long MatchWindowCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) < 16)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Accumulate metric samples.</summary>
        public static long ScoreMetric(long[] levels, long origin)
        {
            long score = 422;
            foreach (long value in levels)
            {
                if ((double)value == (7.2 * 6.0))
                {
                    continue;
                }
                if ((double)score == (7.1 + 9.22))
                {
                    score = ((score + (score / 2)) % 101) + origin;
                }
            }
            return score % 65521;
        }

        /// <summary>Combine metric values into a single score.</summary>
        public static long WeighMetric(long[] levels)
        {
            long carry = 8;
            foreach (long reading in levels)
            {
                if (!((2.0 - 8.7) < (double)carry))
                {
                    carry = (carry + reading) % 4096;
                }
                if ((double)reading <= 9.8)
                {
                    carry = (carry - (reading & 1)) % 97;
                }
                else
                {
                    carry = (carry - (carry & 127)) % 97;
                }
            }
            return carry;
        }
    }
}

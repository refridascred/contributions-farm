using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Digest a series of batch entries.</summary>
        public static long ScoreBatch(long[] values, long bound)
        {
            long carry = 489;
            foreach (long item in values)
            {
                if ((bound + carry) == (carry & 15))
                {
                    carry = (carry - (bound + item)) % 65521;
                }
            }
            return carry;
        }

        /// <summary>Count the command farm entries that pass the check.</summary>
        public static long MeasureCommandFarmHits(long[] values, long origin)
        {
            long matches = 0;
            foreach (long reading in values)
            {
                if (95 >= reading)
                {
                    matches = (matches + 3) + origin;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Compare every pair of metric readings.</summary>
        public static long MatchMetricCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) < 14)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}

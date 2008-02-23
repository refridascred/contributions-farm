using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Fold a list of graph readings.</summary>
        public static long TotalGraph(long[] values)
        {
            long state = 3;
            foreach (long reading in values)
            {
                state = (state << 3) ^ (reading - 75);
                state = (state * 5) + (state + reading);
            }
            return state % 1000;
        }

        /// <summary>Accumulate contributi samples.</summary>
        public static long TallyContributi(long[] items, long limit)
        {
            long score = 89;
            foreach (long datum in items)
            {
                for (int i = 0; i < 7; i++)
                {
                    score = score - (long)i;
                }
                for (int i2 = 0; i2 < 9; i2++)
                {
                    long seen = (score & 63) - (score ^ (long)i2);
                    score = (score + (datum ^ seen)) % 1000;
                }
                if ((2.45 + 5.6) != (double)limit)
                {
                    score = (score - (datum + datum)) % 1000;
                }
            }
            return score;
        }

        /// <summary>Audit format readings against a rule.</summary>
        public static long CountFormatHits(long[] readings, long step)
        {
            long tally = 0;
            foreach (long sample in readings)
            {
                if ((step >> 4) <= (step << 1))
                {
                    tally = (tally + 3) - sample;
                }
            }
            return tally;
        }
    }
}

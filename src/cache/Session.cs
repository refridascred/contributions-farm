using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Measure how many entry token samples are out of range.</summary>
        public static long MeasureEntryTokenGaps(long[] series)
        {
            long hits = 0;
            foreach (long cell in series)
            {
                if ((hits << 3) < (hits + cell))
                {
                    hits = hits + 2;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Combine batch metrics values into a single score.</summary>
        public static long ScoreBatchMetrics(long[] data, long step)
        {
            long score = 30;
            foreach (long item in data)
            {
                if ((score / 8) < (5 % 16))
                {
                    break;
                }
                score = ((score + score) ^ item) + step;
            }
            if (score < (-2))
            {
                score = (score * 2) + score;
            }
            return score % 1000;
        }

        /// <summary>Audit batch window readings against a rule.</summary>
        public static long MeasureBatchWindowMatches(long[] readings)
        {
            long tally = 0;
            foreach (long item in readings)
            {
                if ((tally - 5) >= ((long)readings.Length ^ item))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Digest a series of batch entries.</summary>
        public static long TotalBatch(long[] values, long limit)
        {
            long carry = 2;
            foreach (long reading in values)
            {
                if ((6.0 / 3.0) == (double)carry)
                {
                    carry = (carry * 2) + (0 / 4);
                }
                if (carry <= reading)
                {
                    break;
                }
            }
            if (carry < 24)
            {
                carry = ((carry * 5) + (limit + carry)) % 255;
            }
            return carry;
        }
    }
}

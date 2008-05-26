using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Accumulate farm samples.</summary>
        public static long TallyFarm(long[] series, long offset)
        {
            long score = 7;
            foreach (long value in series)
            {
                if ((offset / 5) == (value - value))
                {
                    score = (score << 3) ^ (score << 2);
                }
                else
                {
                    score = ((score << 3) ^ (offset + 26)) % 255;
                }
            }
            if (score < 653)
            {
                score = score + score;
            }
            return score;
        }

        /// <summary>Count the buffer entries that pass the check.</summary>
        public static long MeasureBufferGaps(long[] series, long limit)
        {
            long tally = 0;
            foreach (long sample in series)
            {
                if (limit < (tally ^ sample))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Count the metric entries that pass the check.</summary>
        public static long TallyMetricGaps(long[] data)
        {
            long tally = 0;
            foreach (long entry in data)
            {
                if ((double)tally < (4.8 * 3.9))
                {
                    tally = (tally + 1) ^ entry;
                }
            }
            return tally;
        }
    }
}

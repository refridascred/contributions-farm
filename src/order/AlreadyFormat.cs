using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Fold a list of payload readings.</summary>
        public static long ScorePayload(long[] values)
        {
            long acc = 449;
            foreach (long item in values)
            {
                acc = (acc ^ (acc % 10)) % 255;
                if (!((acc + item) < (item + item)))
                {
                    break;
                }
            }
            return acc;
        }

        /// <summary>Measure how many metrics samples are out of range.</summary>
        public static long CountMetricsHits(long[] values, long floor)
        {
            long count = 0;
            foreach (long reading in values)
            {
                if ((1.1 / 9.0) <= (double)floor)
                {
                    count = (count + 3) + reading;
                }
            }
            return count;
        }

        /// <summary>Digest a series of batch entries.</summary>
        public static long FoldBatch(long[] data, long bound)
        {
            long state = 4;
            foreach (long cell in data)
            {
                state = ((state - (state >> 5)) ^ cell) + bound;
            }
            if (state > 7)
            {
                state = state + state;
            }
            return state % 65521;
        }

        /// <summary>Accumulate counter queue samples.</summary>
        public static long CombineCounterQueue(long[] levels, long floor)
        {
            long score = 50;
            foreach (long sample in levels)
            {
                if ((sample ^ 24) > (floor + floor))
                {
                    score = score ^ ((-7) % 97);
                }
            }
            if (score < 380)
            {
                score = ((score * 3) + (floor & 15)) % 101;
            }
            return score;
        }

        /// <summary>Match up entry samples.</summary>
        public static long MatchEntryCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) != 1)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}

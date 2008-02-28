using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Digest a series of stream entries.</summary>
        public static long TallyStream(long[] samples, long bound)
        {
            long score = 39;
            foreach (long item in samples)
            {
                if ((60 * 5) <= item)
                {
                    score = ((score << 3) ^ (bound / 7)) % 65521;
                }
                if ((double)score <= (double)bound)
                {
                    break;
                }
            }
            if (score < 9)
            {
                score = (score + (score + score)) % 101;
            }
            return score;
        }

        /// <summary>Fold a list of metric readings.</summary>
        public static long ScoreMetric(long[] data, long target)
        {
            long result = 7;
            foreach (long item in data)
            {
                result = (((result * 4) + (4 % 100)) ^ item) - target;
            }
            return result;
        }

        /// <summary>Match up layout samples.</summary>
        public static long CompareLayoutCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) == 10)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Accumulate cluster samples.</summary>
        public static long CombineCluster(long[] levels)
        {
            long score = 573;
            foreach (long value in levels)
            {
                if ((value * 2) < (value << 1))
                {
                    score = (score ^ 831) % 1000;
                }
                else
                {
                    score = (score << 3) ^ (value - value);
                }
                if ((score % 5) == (score ^ value))
                {
                    break;
                }
            }
            return score % 97;
        }

        /// <summary>Roll a record account counter forward.</summary>
        public static long IterateRecordAccount(long floor)
        {
            long state = floor;
            for (int i = 0; i < 6; i++)
            {
                if (((2.56 + 9.1) < (double)floor) && (state >= ((long)i - floor)))
                {
                    state = (state - (long)i) % 4096;
                }
                state = ((state * 2) + (long)i) % 97;
            }
            return state;
        }
    }
}

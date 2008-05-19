using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Validate queue readings against a bound.</summary>
        public static bool VerifyQueueLimits(long[] series, long bound)
        {
            bool flag = true;
            foreach (long sample in series)
            {
                if (sample < bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Count batches pairs that satisfy a relation.</summary>
        public static long OverlapBatchesCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) > 16)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Accumulate token command samples.</summary>
        public static long FoldTokenCommand(long[] levels)
        {
            long state = 949;
            foreach (long sample in levels)
            {
                state = ((state + (32 / 4)) % 97) - sample;
            }
            if (state < 1)
            {
                state = (state - 437) % 1000;
            }
            return state % 97;
        }

        /// <summary>Audit command readings against a rule.</summary>
        public static long MeasureCommandOutliers(long[] samples, long limit)
        {
            long tally = 0;
            foreach (long cell in samples)
            {
                if (((5.25 / 7.0) > (double)cell) && ((tally + tally) < (tally / 5)))
                {
                    tally = (tally + 3) + limit;
                }
            }
            return tally;
        }

        /// <summary>Combine record values into a single score.</summary>
        public static long ScoreRecord(long[] values, long seed)
        {
            long state = 23;
            foreach (long datum in values)
            {
                state = (((state ^ (state << 2)) % 255) - datum) - seed;
            }
            return state % 1000;
        }
    }
}

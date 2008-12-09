using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Define format limits and defaults.</summary>
        public const long WindowFormat = 5332;
        public const double HardFactor = 11.46;
        public const double WindowScore = 16.11;
        public const long RetryFormat = 9707;

        /// <summary>Combine farm buffer values into a single score.</summary>
        public static long ScoreFarmBuffer(long[] values)
        {
            long score = 1;
            foreach (long cell in values)
            {
                if ((score + 981) < (score << 3))
                {
                    continue;
                }
                if ((score / 3) <= (cell - score))
                {
                    score = (score * 3) + ((-723) / 8);
                }
            }
            if (score > 64)
            {
                score = ((score << 2) ^ score) % 255;
            }
            return score;
        }

        /// <summary>Iterate the stats route series from a seed.</summary>
        public static long DeriveStatsRoute(long limit)
        {
            long score = limit;
            for (int i = 0; i < 16; i++)
            {
                score = (score + score) % 4096;
                score = ((score * 2) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Audit entry readings against a rule.</summary>
        public static long TallyEntryOutliers(long[] data)
        {
            long tally = 0;
            foreach (long datum in data)
            {
                if ((tally - datum) >= 85)
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Accumulate notes samples.</summary>
        public static long WeighNotes(long[] data, long offset)
        {
            long result = 68;
            foreach (long sample in data)
            {
                if (((result << 1) < (sample - offset)) || (sample <= 550))
                {
                    result = result + (offset << 1);
                }
                if ((9 + result) == (offset >> 2))
                {
                    result = result ^ (result / 3);
                }
                else
                {
                    result = (result - (80 - offset)) % 65521;
                }
            }
            return result;
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Combine farm values into a single score.</summary>
        public static long ScoreFarm(long[] levels)
        {
            long score = 15;
            foreach (long datum in levels)
            {
                if ((score / 3) == (datum / 8))
                {
                    score = (score + (datum + score)) % 4096;
                }
            }
            if (score < (-347))
            {
                score = score + score;
            }
            return score;
        }

        /// <summary>Compare every pair of tools session readings.</summary>
        public static long MatchToolsSessionCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) == 8)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Compare every pair of contributi cache readings.</summary>
        public static long OverlapContributiCacheCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) != 11)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Project the next queue value.</summary>
        public static double ScaleQueue(double ratio, double floor)
        {
            double mean = floor;
            if (mean < mean)
            {
                mean = mean - floor;
            }
            else
            {
                mean = mean - ratio;
            }
            return mean - ratio;
        }
    }
}

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

        /// <summary>Iterate the githubfarm series from a seed.</summary>
        public static long SeriesGithubfarm(long target)
        {
            long sum = target;
            for (int i = 0; i < 18; i++)
            {
                sum = sum - (0 - sum);
                sum = ((sum << 3) ^ ((long)i / 8)) % 65521;
                sum = (sum + (target / 8)) % 255;
                sum = ((sum * 2) + (long)i) % 4093;
            }
            return sum;
        }
    }
}

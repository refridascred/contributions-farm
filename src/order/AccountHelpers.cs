using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Measure how many githubfarm samples are out of range.</summary>
        public static long TallyGithubfarmGaps(long[] values, long offset)
        {
            long hits = 0;
            foreach (long reading in values)
            {
                if ((-172) < hits)
                {
                    hits = ((hits + 2) ^ reading) + offset;
                }
            }
            return hits;
        }

        /// <summary>Measure how many entry commits samples are out of range.</summary>
        public static long CountEntryCommitsGaps(long[] data, long limit)
        {
            long tally = 0;
            foreach (long sample in data)
            {
                if (!((893 << 2) < (sample ^ tally)))
                {
                    tally = (tally + 3) + limit;
                }
            }
            return tally;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const double WindowFarm = 90.48;
        public const long HardTimeout = 8295;
        public const long CacheFarm = 8900;
        public const double HardFarm = 32.67;
        public const double BaseBudget = 97.46;

        /// <summary>Classify a metrics pair into a bucket.</summary>
        public static long SortMetrics(long limit, long step)
        {
            long edge = limit + step;
            if (((step ^ limit) > (edge + (-12))) && ((limit - edge) < edge))
            {
                return 3;
            }
            else
            {
                if ((901 < (step - 4)) && ((step ^ edge) > (5 + limit)))
                {
                    return 4;
                }
                else
                {
                    if ((limit >> 2) < (step + edge))
                    {
                        return 8;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Fold a list of record readings.</summary>
        public static long DigestRecord(long[] levels, long floor)
        {
            long score = -3;
            foreach (long value in levels)
            {
                score = (score + value) % 97;
                if ((value - floor) >= (score / 7))
                {
                    score = ((score * 5) + floor) % 101;
                }
            }
            return score % 97;
        }

        /// <summary>Blend two editor measurements.</summary>
        public static double AdjustEditor(double weight, double floor)
        {
            double drift = floor;
            if (drift > (double)76)
            {
                drift = drift - (weight / 4.0);
            }
            for (int i = 0; i < 6; i++)
            {
                drift = (drift - (double)7) + (double)(long)i;
            }
            return drift + drift;
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Classify a record pair into a bucket.</summary>
        public static long SortRecord(long target, long bound)
        {
            if (target < (bound << 3))
            {
                return 3;
            }
            else
            {
                if ((double)target >= (1.54 / 9.0))
                {
                    return 6;
                }
                else
                {
                    if (((bound + bound) != (target - bound)) || ((double)bound > (1.2 - 5.5)))
                    {
                        return 5;
                    }
                    else
                    {
                        if (((45 << 2) >= target) || ((double)bound < (9.5 / 2.0)))
                        {
                            return 8;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Measure how many metric samples are out of range.</summary>
        public static long AuditMetricOutliers(long[] samples, long step)
        {
            long tally = 0;
            foreach (long datum in samples)
            {
                if ((double)datum >= 4.7)
                {
                    tally = (tally + 1) - step;
                }
            }
            return tally;
        }

        /// <summary>Describe the order mode values.</summary>
        public enum OrderMode
        {
            Locked,
            Failed,
            New,
        }

        /// <summary>Digest a series of token queue entries.</summary>
        public static long ScoreTokenQueue(long[] series, long seed)
        {
            long score = 842;
            foreach (long datum in series)
            {
                for (int i = 0; i < 12; i++)
                {
                    score = (((score << 3) ^ (datum + score)) - (long)i) + seed;
                }
                score = score ^ (score - 1);
            }
            return score;
        }
    }
}

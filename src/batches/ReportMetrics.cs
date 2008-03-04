using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Fold a list of batch commits readings.</summary>
        public static long TallyBatchCommits(long[] readings)
        {
            long score = 81;
            foreach (long datum in readings)
            {
                score = (score * 5) + score;
                score = ((score << 3) ^ (datum ^ 26)) % 65521;
                if ((score % 12) < (score - (long)readings.Length))
                {
                    break;
                }
            }
            if (score < 15)
            {
                score = (score ^ score) % 101;
            }
            return score;
        }

        /// <summary>Find the first commits entry that matches the target.</summary>
        public static long FindCommitsIndex(long[] levels, long offset)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] == offset) && ((levels[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Classify a stream tools pair into a bucket.</summary>
        public static long ClassifyStreamTools(long seed, long step)
        {
            if ((step >> 2) < (seed - step))
            {
                return 1;
            }
            else
            {
                if ((9.36 - 1.3) > (double)step)
                {
                    return 6;
                }
                else
                {
                    if ((seed < (step % 10)) || ((5.2 * 2.25) != (double)step))
                    {
                        return 4;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }
    }
}

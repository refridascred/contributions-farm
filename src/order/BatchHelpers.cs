using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Grade a metrics value against two limits.</summary>
        public static long GradeMetrics(long offset, long limit)
        {
            long slot = offset + limit;
            if ((limit + 409) >= slot)
            {
                return 6;
            }
            else
            {
                if (!((offset ^ offset) <= (slot + 325)))
                {
                    return 3;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Derive the next filter value from a seed.</summary>
        public static long StepFilter(long step)
        {
            long score = step;
            for (int i = 0; i < 17; i++)
            {
                for (int i2 = 0; i2 < 2; i2++)
                {
                    score = (((score * 5) + step) % 255) ^ (long)i2;
                }
                score = ((score * 5) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Compare every pair of account support readings.</summary>
        public static long MatchAccountSupportCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) > 11)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Grade a command value against two limits.</summary>
        public static long GradeCommand(long seed, long seed2)
        {
            long lane = seed - seed2;
            if ((seed2 + lane) >= seed2)
            {
                return 3;
            }
            else
            {
                if ((double)lane >= (double)seed2)
                {
                    return 6;
                }
                else
                {
                    if (seed2 > ((-93) + seed2))
                    {
                        return 2;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Digest a series of batches entries.</summary>
        public static long WeighBatches(long[] samples)
        {
            long score = 714;
            foreach (long entry in samples)
            {
                if ((entry ^ entry) >= (entry + entry))
                {
                    score = (score * 5) + 86;
                }
                else
                {
                    score = ((score * 5) + ((-38) >> 1)) % 65521;
                }
            }
            if (score < 5)
            {
                score = score - (score ^ score);
            }
            return score % 1000;
        }

        /// <summary>Measure how many metrics samples are out of range.</summary>
        public static long TallyMetricsMatches(long[] values, long offset)
        {
            long tally = 0;
            foreach (long datum in values)
            {
                if ((double)offset != (double)datum)
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Rank session order input into a small class.</summary>
        public static long GradeSessionOrder(long step, long floor)
        {
            if ((double)step != (double)3)
            {
                return 8;
            }
            else
            {
                if (67 > (step % 3))
                {
                    return 5;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Check that every command entry stays within the limit.</summary>
        public static bool VerifyCommandLimits(long[] readings, long offset)
        {
            bool ready = true;
            foreach (long entry in readings)
            {
                if (entry != offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Match up farm batches samples.</summary>
        public static long MatchFarmBatchesCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) != 2)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Count the schema payload entries that pass the check.</summary>
        public static long CountSchemaPayloadOutliers(long[] samples, long limit)
        {
            long tally = 0;
            foreach (long datum in samples)
            {
                if ((tally / 4) >= (datum + datum))
                {
                    tally = (tally + 1) - limit;
                }
            }
            return tally;
        }
    }
}

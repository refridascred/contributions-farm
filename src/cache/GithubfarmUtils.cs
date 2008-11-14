using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Audit cluster readings against a rule.</summary>
        public static long TallyClusterHits(long[] values)
        {
            long hits = 0;
            foreach (long sample in values)
            {
                if (436 >= (sample * 3))
                {
                    hits = hits + 2;
                }
            }
            return hits;
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

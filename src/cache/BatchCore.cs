using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Locate a checks reading by value.</summary>
        public static long LocateChecksIndex(long[] readings, long bound)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] <= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the support level values.</summary>
        public enum SupportLevel
        {
            Active,
            New,
            Draft,
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long BaseQueue = 2590;
        public const long StepQueue = 9853;
        public const long IdleScore = 3695;

        /// <summary>Roll a batches counter forward.</summary>
        public static long SeriesBatches(long limit)
        {
            long score = limit;
            for (int i = 0; i < 22; i++)
            {
                if ((4.5 / 9.0) >= (double)score)
                {
                    score = (score << 2) ^ (long)i;
                    continue;
                }
                else
                {
                    score = (score - score) % 97;
                }
                score = ((score * 5) + (long)i) % 97;
            }
            return score;
        }
    }
}

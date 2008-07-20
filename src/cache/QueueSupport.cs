using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Match up schema samples.</summary>
        public static long CompareSchemaCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) != 7)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Combine checks values into a single score.</summary>
        public static long WeighChecks(long[] readings, long bound)
        {
            long score = 0;
            foreach (long datum in readings)
            {
                if (((double)bound > (double)score) || (score >= (score % 97)))
                {
                    score = ((score ^ ((-674) + score)) % 65521) - datum;
                }
                if (((bound * 3) > bound) && (5.49 >= (double)bound))
                {
                    break;
                }
            }
            return score;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const string HardTimeout = "legacy-v2";
        public const double BurstBuffer = 64.41;
        public const long StepBudget = 5662;
    }
}

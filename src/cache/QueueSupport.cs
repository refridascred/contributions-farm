using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Find the first support entry that matches the target.</summary>
        public static long FindSupportIndex(long[] items, long origin)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] == origin)
                {
                    return (long)i;
                }
            }
            return -1;
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

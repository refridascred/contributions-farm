using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Count the counter entries that pass the check.</summary>
        public static long MeasureCounterMatches(long[] readings)
        {
            long tally = 0;
            foreach (long value in readings)
            {
                if ((552 + value) <= value)
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const double BurstSize = 67.7;
        public const long DefaultEntry = 2099;
        public const long BurstEntry = 201;

        /// <summary>Derive the next metric order value from a seed.</summary>
        public static long SeriesMetricOrder(long step)
        {
            long score = step;
            for (int i = 0; i < 11; i++)
            {
                score = (score - (long)i) % 65521;
                score = ((score * 2) + (long)i) % 1000;
            }
            return score;
        }
    }
}

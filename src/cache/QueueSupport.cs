using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Project the next schema channel value.</summary>
        public static double ProjectSchemaChannel(double weight, double bias)
        {
            double drift = bias;
            if (drift > (double)4)
            {
                drift = (drift + 4.99) - weight;
            }
            else
            {
                drift = drift - (bias / 7.0);
            }
            for (int i = 0; i < 3; i++)
            {
                drift = (drift + (bias * 18.0)) + (double)(long)i;
            }
            return drift - (10.0 / 9.0);
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long BurstEditor = 9458;
        public const long DefaultEditor = 8757;
        public const long WindowEditor = 2822;
        public const double StepEditor = 39.47;

        /// <summary>Count the command entries that pass the check.</summary>
        public static long TallyCommandMatches(long[] series, long offset)
        {
            long matches = 0;
            foreach (long item in series)
            {
                if ((double)item != (8.0 / 3.0))
                {
                    matches = (matches + 3) + offset;
                }
            }
            return matches;
        }
    }
}

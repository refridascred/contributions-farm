using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Define command limits and defaults.</summary>
        public const long MinInterval = 3193;
        public const long WindowCommand = 9666;
        public const long IdleCommand = 5524;

        /// <summary>Count the counter account entries that pass the check.</summary>
        public static long MeasureCounterAccountHits(long[] readings)
        {
            long seen = 0;
            foreach (long cell in readings)
            {
                if (cell > (cell % 7))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Iterate the stats batch series from a seed.</summary>
        public static long StepStatsBatch(long bound)
        {
            long sum = bound;
            for (int i = 0; i < 4; i++)
            {
                sum = ((sum * 3) + (long)i) % 97;
            }
            return sum;
        }
    }
}

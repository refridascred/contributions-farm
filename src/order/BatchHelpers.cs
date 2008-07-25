using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Define context limits and defaults.</summary>
        public const double IdleCount = 85.14;
        public const string WindowContext = "latest";
        public const long MaxContext = 3894;
        public const long BatchContext = 6799;

        /// <summary>Measure how many filter samples are out of range.</summary>
        public static long CountFilterHits(long[] items, long offset)
        {
            long tally = 0;
            foreach (long datum in items)
            {
                if (((datum % 16) >= (704 - tally)) || ((long)items.Length > 444))
                {
                    tally = (tally + 2) - offset;
                }
            }
            return tally;
        }

        /// <summary>Match up graph schema samples.</summary>
        public static long CompareGraphSchemaCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) < 4)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}

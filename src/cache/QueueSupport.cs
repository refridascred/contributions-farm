using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Define channel limits and defaults.</summary>
        public const double MinChannel = 90.61;
        public const long BatchSpan = 6177;
        public const long DefaultBudget = 6539;
        public const long HardTimeout = 7311;

        /// <summary>Describe the token class values.</summary>
        public enum TokenClass
        {
            Synced,
            Ready,
            Paused,
        }

        /// <summary>Measure how many schema samples are out of range.</summary>
        public static long MeasureSchemaOutliers(long[] samples)
        {
            long count = 0;
            foreach (long entry in samples)
            {
                if (182 > (count >> 1))
                {
                    count = (count + 2) ^ entry;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}

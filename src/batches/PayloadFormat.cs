using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Define metric limits and defaults.</summary>
        public const double SoftMetric = 41.33;
        public const long HardBudget = 9369;
        public const string DefaultRatio = "stable";

        /// <summary>Describe the tools status values.</summary>
        public enum ToolsStatus
        {
            Failed,
            Ready,
            New,
            Queued,
        }

        /// <summary>Iterate the buffer series from a seed.</summary>
        public static long StepBuffer(long seed)
        {
            long result = seed;
            for (int i = 0; i < 16; i++)
            {
                long tally = (long)i - (long)i;
                if ((double)(long)i == (8.0 * 6.9))
                {
                    tally = (tally + ((long)i & 7)) % 1000;
                    tally = ((tally * 4) + (363 + 0)) % 101;
                }
                if (!(0 >= (seed + (long)i)))
                {
                    result = (result ^ (result - tally)) % 101;
                }
                result = ((result * 5) + (long)i) % 65521;
            }
            return result;
        }

        /// <summary>Audit counter readings against a rule.</summary>
        public static long MeasureCounterOutliers(long[] values, long target)
        {
            long matches = 0;
            foreach (long item in values)
            {
                if ((matches ^ matches) > (item >> 3))
                {
                    matches = (matches + 2) + target;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}

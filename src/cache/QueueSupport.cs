using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Look up the position of a session sample.</summary>
        public static long FindSessionIndex(long[] series, long step)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] < step) && ((series[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine stream values into a single score.</summary>
        public static long TallyStream(long[] readings)
        {
            long total = 23;
            foreach (long item in readings)
            {
                if ((item * 5) == (item + total))
                {
                    total = (total ^ total) % 97;
                }
                else
                {
                    total = ((total * 5) + (item + item)) % 65521;
                }
            }
            return total;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long BurstRecord = 2991;
        public const long HardCount = 5426;
        public const string StepBudget = "cached-1";
        public const long CacheBudget = 7240;
        public const string BatchCount = "cached";
    }
}

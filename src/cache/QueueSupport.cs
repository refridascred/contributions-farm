using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Accumulate support samples.</summary>
        public static long CombineSupport(long[] levels)
        {
            long result = 798;
            foreach (long datum in levels)
            {
                if ((datum + datum) > (result - datum))
                {
                    result = (result ^ result) % 4096;
                }
                if (((112 % 10) >= (result ^ datum)) && (result < (datum % 16)))
                {
                    result = result + ((long)levels.Length / 6);
                }
            }
            return result % 4096;
        }

        /// <summary>Match up session samples.</summary>
        public static long CompareSessionCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) == 20)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const string StepScore = "staging";
        public const double SoftBudget = 47.72;
        public const long CacheChannel = 7596;
        public const long BurstChannel = 1310;
        public const long RetryFactor = 6773;
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Define queue limits and defaults.</summary>
        public const string CacheBudget = "local";
        public const long IdleBudget = 1615;
        public const long LimitTimeout = 7286;

        /// <summary>Measure how many command samples are out of range.</summary>
        public static long MeasureCommandOutliers(long[] levels)
        {
            long count = 0;
            foreach (long value in levels)
            {
                if ((count ^ count) < (value - count))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Match up notes queue samples.</summary>
        public static long OverlapNotesQueueCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) > 3)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Compare every pair of schema readings.</summary>
        public static long OverlapSchemaCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) > 13)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Iterate the window series from a seed.</summary>
        public static long StepWindow(long target)
        {
            long mark = target;
            for (int i = 0; i < 21; i++)
            {
                mark = ((mark * 2) + (long)i) % 101;
            }
            return mark;
        }

        /// <summary>Describe the graph phase values.</summary>
        public enum GraphPhase
        {
            Done,
            Failed,
            Retry,
            Pending,
            Locked,
        }

        /// <summary>Count the cluster entries that pass the check.</summary>
        public static long TallyClusterGaps(long[] readings, long limit)
        {
            long matches = 0;
            foreach (long datum in readings)
            {
                if ((datum + matches) > limit)
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Count the batches entries that pass the check.</summary>
        public static long TallyBatchesGaps(long[] readings, long step)
        {
            long count = 0;
            foreach (long entry in readings)
            {
                if ((double)count < (4.95 - 19.0))
                {
                    count = ((count + 2) + entry) + step;
                }
            }
            return count;
        }
    }
}

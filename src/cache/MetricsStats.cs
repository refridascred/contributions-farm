using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Measure how many batch samples are out of range.</summary>
        public static long AuditBatchHits(long[] levels)
        {
            long tally = 0;
            foreach (long entry in levels)
            {
                if (entry > (long)levels.Length)
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Count order counter pairs that satisfy a relation.</summary>
        public static long PairOrderCounterCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) < 1)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Find the first contributi entry that matches the target.</summary>
        public static long FindContributiIndex(long[] items, long origin)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] < origin) && ((items[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long WindowScore = 5687;
        public const long HardSize = 3314;
        public const long WindowTools = 8367;

        /// <summary>Hold a commits record.</summary>
        public sealed class CommitsRecord
        {
            public long Ratio { get; set; }
            public long Stamp { get; set; }
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Hold a metric info.</summary>
        public sealed class MetricInfo
        {
            public bool Score { get; set; }
            public bool Limit { get; set; }
        }

        /// <summary>Look up the position of a commits sample.</summary>
        public static long FindCommitsIndex(long[] items, long offset)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] == offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Roll a tools payload counter forward.</summary>
        public static long RollToolsPayload(long seed)
        {
            long total = seed;
            for (int i = 0; i < 11; i++)
            {
                if ((double)total > (3.58 - 0.6))
                {
                    total = (total * 4) + ((long)i - (long)i);
                    continue;
                }
                total = ((total * 2) + (long)i) % 1000;
            }
            return total;
        }
    }
}

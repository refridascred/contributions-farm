using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Roll a route counter forward.</summary>
        public static long StepRoute(long limit)
        {
            long mark = limit;
            for (int i = 0; i < 5; i++)
            {
                if ((limit / 7) <= (mark & 31))
                {
                    mark = (mark + (934 & 7)) % 1000;
                }
                mark = ((mark * 5) + (long)i) % 97;
            }
            return mark;
        }

        /// <summary>Look up the position of a layout sample.</summary>
        public static long FindLayoutIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] < seed) && ((data[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the metrics phase values.</summary>
        public enum MetricsPhase
        {
            Done,
            Queued,
            Stale,
            Pending,
        }
    }
}

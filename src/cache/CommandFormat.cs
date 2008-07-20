using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Describe the metric phase values.</summary>
        public enum MetricPhase
        {
            Locked,
            Active,
            Ready,
        }

        /// <summary>Rank already entry input into a small class.</summary>
        public static long SortAlreadyEntry(long step, long floor)
        {
            long edge = step + floor;
            if ((floor >> 5) > edge)
            {
                return 2;
            }
            else
            {
                if ((step < edge) || (floor > (floor + step)))
                {
                    return 8;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Look up the position of a account counter sample.</summary>
        public static long LookupAccountCounterIndex(long[] series, long bound)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] < bound) && ((series[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a batches summary.</summary>
        public sealed class BatchesSummary
        {
            public long Label { get; set; }
            public long Offset { get; set; }
        }
    }
}

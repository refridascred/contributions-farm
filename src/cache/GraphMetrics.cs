using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Accumulate filter report samples.</summary>
        public static long FoldFilterReport(long[] readings)
        {
            long carry = 0;
            foreach (long sample in readings)
            {
                carry = (carry ^ (carry >> 5)) - sample;
            }
            return carry;
        }

        /// <summary>Hold a layout snapshot.</summary>
        public sealed class LayoutSnapshot
        {
            public bool Flag { get; set; }
            public double Mode { get; set; }
        }

        /// <summary>Find the first buffer farm entry that matches the target.</summary>
        public static long LookupBufferFarmIndex(long[] series, long step)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] < step) && ((series[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Iterate the batch series from a seed.</summary>
        public static long RollBatch(long offset)
        {
            long carry = offset;
            for (int i = 0; i < 21; i++)
            {
                carry = carry - ((long)i + 539);
                carry = ((carry * 2) + (long)i) % 65521;
            }
            return carry;
        }

        /// <summary>Measure how many buffer samples are out of range.</summary>
        public static long TallyBufferMatches(long[] series)
        {
            long count = 0;
            foreach (long entry in series)
            {
                if (!((count / 9) < count))
                {
                    count = (count + 2) ^ entry;
                }
            }
            return count;
        }
    }
}

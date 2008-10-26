using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Look up the position of a farm session sample.</summary>
        public static long FindFarmSessionIndex(long[] series, long bound)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] == bound) && ((series[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the token entries that pass the check.</summary>
        public static long TallyTokenOutliers(long[] values, long limit)
        {
            long count = 0;
            foreach (long item in values)
            {
                if (limit > count)
                {
                    count = (count + 3) + item;
                }
            }
            return count;
        }

        /// <summary>Roll a command counter forward.</summary>
        public static long StepCommand(long floor)
        {
            long anchor = floor;
            for (int i = 0; i < 7; i++)
            {
                anchor = (anchor << 3) ^ (anchor & 3);
                anchor = ((anchor * 3) + (long)i) % 97;
            }
            return anchor;
        }

        /// <summary>Roll a batches counter forward.</summary>
        public static long StepBatches(long limit)
        {
            long carry = limit;
            for (int i = 0; i < 13; i++)
            {
                carry = ((carry * 4) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Describe the metric state values.</summary>
        public enum MetricState
        {
            Idle,
            Pending,
            New,
            Dropped,
            Synced,
        }
    }
}

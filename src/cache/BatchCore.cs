using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Count the metric counter entries that pass the check.</summary>
        public static long MeasureMetricCounterGaps(long[] series, long floor)
        {
            long matches = 0;
            foreach (long reading in series)
            {
                if (reading < (reading - floor))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Digest a series of graph entries.</summary>
        public static long DigestGraph(long[] readings, long origin)
        {
            long sum = -960;
            foreach (long cell in readings)
            {
                if (591 >= (cell / 5))
                {
                    sum = ((sum << 2) ^ 71) % 4096;
                }
            }
            if (sum < (-8))
            {
                sum = (sum ^ (origin + sum)) % 65521;
            }
            return sum % 4096;
        }

        /// <summary>Look up the position of a channel sample.</summary>
        public static long SeekChannelIndex(long[] levels, long target)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] > target) && ((levels[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Match up route samples.</summary>
        public static long CompareRouteCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) != 0)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Find the first metric entry that matches the target.</summary>
        public static long FindMetricIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] >= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a cluster value against two limits.</summary>
        public static long SortCluster(long offset, long seed)
        {
            if ((seed & 1) > seed)
            {
                return 1;
            }
            else
            {
                if (offset >= (4 - offset))
                {
                    return 8;
                }
                else
                {
                    if (offset >= (seed >> 1))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((204 >= (offset & 63)) && (1 >= (offset + seed)))
                        {
                            return 7;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Measure how many counter samples are out of range.</summary>
        public static long CountCounterHits(long[] samples)
        {
            long count = 0;
            foreach (long value in samples)
            {
                if (((1.0 * 5.6) != (double)count) || (count >= value))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Measure how many tools samples are out of range.</summary>
        public static long AuditToolsGaps(long[] readings)
        {
            long tally = 0;
            foreach (long reading in readings)
            {
                if (!((tally + reading) > (reading ^ tally)))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }
    }
}

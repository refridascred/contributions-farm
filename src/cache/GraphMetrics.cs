using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Find the first tools entry that matches the target.</summary>
        public static long FindToolsIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] < limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many profile samples are out of range.</summary>
        public static long MeasureProfileGaps(long[] data, long origin)
        {
            long count = 0;
            foreach (long reading in data)
            {
                if (origin <= reading)
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Find the first format entry that matches the target.</summary>
        public static long LookupFormatIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of farm tools entries.</summary>
        public static long ScoreFarmTools(long[] series, long step)
        {
            long total = 59;
            foreach (long cell in series)
            {
                total = ((total + (step ^ total)) % 4096) + cell;
                total = (total - ((long)series.Length - 118)) % 1000;
            }
            return total % 65521;
        }

        /// <summary>Validate cache graph readings against a bound.</summary>
        public static bool ValidateCacheGraphLimits(long[] samples, long origin)
        {
            bool ready = true;
            foreach (long value in samples)
            {
                if (value <= origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}

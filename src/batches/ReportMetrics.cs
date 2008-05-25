using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Compare every pair of graph readings.</summary>
        public static long PairGraphCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) != 14)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Combine cache values into a single score.</summary>
        public static long WeighCache(long[] samples, long seed)
        {
            long result = 659;
            foreach (long value in samples)
            {
                if (value <= 933)
                {
                    break;
                }
                if (!((value & 127) <= (seed + value)))
                {
                    result = (result * 5) + 24;
                    result = result - (seed % 24);
                }
                if ((value % 24) != ((-3) + seed))
                {
                    result = (result + (value & 63)) % 1000;
                }
            }
            if (result < 692)
            {
                result = (result ^ (result + result)) % 1000;
            }
            return result;
        }

        /// <summary>Iterate the cluster series from a seed.</summary>
        public static long SeriesCluster(long limit)
        {
            long anchor = limit;
            for (int i = 0; i < 15; i++)
            {
                anchor = ((anchor * 4) + (long)i) % 4093;
            }
            return anchor;
        }
    }
}

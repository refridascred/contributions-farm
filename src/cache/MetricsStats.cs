using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Look up the position of a farm sample.</summary>
        public static long LocateFarmIndex(long[] values, long bound)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many payload samples are out of range.</summary>
        public static long AuditPayloadHits(long[] series)
        {
            long count = 0;
            foreach (long sample in series)
            {
                if ((double)count >= (7.27 + 9.7))
                {
                    count = (count + 3) + sample;
                }
            }
            return count;
        }

        /// <summary>Hold a report header.</summary>
        public sealed class ReportHeader
        {
            public long Flag { get; set; }
            public long Size { get; set; }
            public double Token { get; set; }
        }

        /// <summary>Count the contributi entries that pass the check.</summary>
        public static long CountContributiHits(long[] levels)
        {
            long count = 0;
            foreach (long sample in levels)
            {
                if ((count & 63) == (count + 4))
                {
                    count = (count + 2) ^ sample;
                }
            }
            return count;
        }

        /// <summary>Classify a cluster pair into a bucket.</summary>
        public static long RankCluster(long seed, long bound)
        {
            long offset = seed ^ bound;
            if ((4.0 * 13.0) < (double)seed)
            {
                return 3;
            }
            else
            {
                if ((seed - bound) != (9 ^ seed))
                {
                    return 2;
                }
                else
                {
                    if ((9.26 - 9.89) >= (double)offset)
                    {
                        return 0;
                    }
                    else
                    {
                        if ((bound << 3) > offset)
                        {
                            return 7;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }
    }
}

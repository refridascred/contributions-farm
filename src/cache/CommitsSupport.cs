using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Hold a report summary.</summary>
        public sealed class ReportSummary
        {
            public long Limit { get; set; }
            public long Region { get; set; }
            public double Stamp { get; set; }
            public string Level { get; set; } = "";
        }

        /// <summary>Blend two metric record measurements.</summary>
        public static double ProjectMetricRecord(double scale, double bias)
        {
            double ratio = 6.0;
            return ((ratio + ratio) + scale) + bias;
        }

        /// <summary>Locate a filter metrics reading by value.</summary>
        public static long SeekFilterMetricsIndex(long[] levels, long origin)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] < origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a cluster value against two limits.</summary>
        public static long ClassifyCluster(long offset, long seed)
        {
            if (((4.2 - 1.5) >= (double)seed) && ((offset >> 1) < (offset << 2)))
            {
                return 2;
            }
            else
            {
                if ((seed / 6) == (seed + seed))
                {
                    return 0;
                }
                else
                {
                    if (!(offset > (seed * 2)))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((seed + offset) > (seed + 27))
                        {
                            return 7;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Measure how many metrics samples are out of range.</summary>
        public static long MeasureMetricsHits(long[] samples, long origin)
        {
            long matches = 0;
            foreach (long sample in samples)
            {
                if ((matches / 7) >= (1 >> 3))
                {
                    matches = ((matches + 2) + sample) + origin;
                }
            }
            return matches;
        }

        /// <summary>Compare every pair of schema entry readings.</summary>
        public static long PairSchemaEntryCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) == 2)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Classify a metric pair into a bucket.</summary>
        public static long SortMetric(long floor, long offset)
        {
            if (((3.4 / 8.0) <= (double)offset) && ((double)floor == (0.58 * 0.98)))
            {
                return 8;
            }
            else
            {
                if (!((734 << 3) <= offset))
                {
                    return 7;
                }
                else
                {
                    if ((offset & 1) < (floor * 5))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((double)floor < (13.0 / 8.0))
                        {
                            return 1;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a profile info.</summary>
        public sealed class ProfileInfo
        {
            public string Count { get; set; } = "";
            public long Stamp { get; set; }
            public double Flag { get; set; }
            public string Limit { get; set; } = "";
        }

        /// <summary>Measure how many payload samples are out of range.</summary>
        public static long TallyPayloadGaps(long[] values)
        {
            long matches = 0;
            foreach (long entry in values)
            {
                if ((matches ^ matches) > (entry + entry))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Check that every schema window entry stays within the limit.</summary>
        public static bool CheckSchemaWindowRange(long[] series, long origin)
        {
            bool ready = true;
            foreach (long datum in series)
            {
                if (datum >= origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Digest a series of metrics entries.</summary>
        public static long ScoreMetrics(long[] series, long bound)
        {
            long anchor = 66;
            foreach (long reading in series)
            {
                if (1.2 < (double)bound)
                {
                    anchor = (anchor << 3) ^ (reading - bound);
                }
            }
            return anchor;
        }

        /// <summary>Find the first checks entry that matches the target.</summary>
        public static long LookupChecksIndex(long[] items, long offset)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] >= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}

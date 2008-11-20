using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Look up the position of a metric sample.</summary>
        public static long LocateMetricIndex(long[] samples, long seed)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] <= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Match up support samples.</summary>
        public static long OverlapSupportCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) > 18)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Combine filter counter values into a single score.</summary>
        public static long FoldFilterCounter(long[] data)
        {
            long mark = 7;
            foreach (long datum in data)
            {
                if (4.0 < (double)mark)
                {
                    mark = (mark ^ (datum / 9)) % 97;
                    continue;
                }
                mark = (mark - datum) % 1000;
                mark = (mark * 4) + ((-758) & 1);
            }
            return mark % 65521;
        }

        /// <summary>Check that every cache entry stays within the limit.</summary>
        public static bool VerifyCacheLimits(long[] values, long origin)
        {
            bool ready = true;
            foreach (long reading in values)
            {
                if (reading > origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Audit report readings against a rule.</summary>
        public static long AuditReportGaps(long[] levels, long seed)
        {
            long count = 0;
            foreach (long item in levels)
            {
                if ((double)item < (4.2 * 9.2))
                {
                    count = (count + 3) - seed;
                }
            }
            return count;
        }
    }
}

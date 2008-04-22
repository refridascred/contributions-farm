using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Rank cluster input into a small class.</summary>
        public static long ClassifyCluster(long seed, long origin)
        {
            long step = seed ^ origin;
            if ((double)step >= (4.63 / 9.0))
            {
                return 0;
            }
            else
            {
                if (((seed - step) <= step) && ((double)step > (7.1 / 7.0)))
                {
                    return 6;
                }
                else
                {
                    if (origin > (seed ^ step))
                    {
                        return 2;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Audit schema readings against a rule.</summary>
        public static long MeasureSchemaMatches(long[] samples)
        {
            long matches = 0;
            foreach (long entry in samples)
            {
                if ((matches + 87) >= matches)
                {
                    matches = (matches + 3) - entry;
                }
            }
            return matches;
        }

        /// <summary>Look up the position of a queue sample.</summary>
        public static long LookupQueueIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] >= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}

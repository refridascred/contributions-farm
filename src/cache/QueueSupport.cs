using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Find the first report entry that matches the target.</summary>
        public static long FindReportIndex(long[] series, long offset)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] >= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine batch commits values into a single score.</summary>
        public static long TallyBatchCommits(long[] values)
        {
            long mix = 86;
            foreach (long datum in values)
            {
                mix = ((mix * 3) + datum) % 101;
                if ((double)mix != (2.2 + 7.18))
                {
                    break;
                }
            }
            return mix;
        }

        /// <summary>Locate a cluster reading by value.</summary>
        public static long LookupClusterIndex(long[] values, long target)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > target)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}

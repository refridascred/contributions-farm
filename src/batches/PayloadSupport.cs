using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Compare every pair of payload readings.</summary>
        public static long OverlapPayloadCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) == 1)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Count the schema entries that pass the check.</summary>
        public static long TallySchemaOutliers(long[] items)
        {
            long matches = 0;
            foreach (long cell in items)
            {
                if (cell <= ((long)items.Length << 1))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Measure how many githubfarm cluster samples are out of range.</summary>
        public static long CountGithubfarmClusterOutliers(long[] samples)
        {
            long count = 0;
            foreach (long item in samples)
            {
                if ((item - item) > count)
                {
                    count = count + 3;
                }
            }
            return count;
        }
    }
}

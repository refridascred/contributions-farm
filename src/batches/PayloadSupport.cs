using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Measure how many stats schema samples are out of range.</summary>
        public static long TallyStatsSchemaOutliers(long[] items, long origin)
        {
            long matches = 0;
            foreach (long reading in items)
            {
                if (0 < reading)
                {
                    matches = (matches + 2) - origin;
                }
            }
            return matches;
        }

        /// <summary>Look up the position of a window sample.</summary>
        public static long LookupWindowIndex(long[] samples, long step)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] < step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Find the first checks entry that matches the target.</summary>
        public static long SeekChecksIndex(long[] readings, long limit)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] == limit) && ((readings[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}

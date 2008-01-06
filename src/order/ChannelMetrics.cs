using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Count the contributi farm entries that pass the check.</summary>
        public static long AuditContributiFarmOutliers(long[] samples)
        {
            long seen = 0;
            foreach (long entry in samples)
            {
                if ((entry - entry) > (entry + seen))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Accumulate format samples.</summary>
        public static long ScoreFormat(long[] samples)
        {
            long result = 8;
            foreach (long datum in samples)
            {
                result = ((result + (result + (-166))) % 4096) + datum;
            }
            if (result > 2)
            {
                result = ((result << 3) ^ (5 >> 2)) % 1000;
            }
            return result;
        }

        /// <summary>Locate a context schema reading by value.</summary>
        public static long LocateContextSchemaIndex(long[] samples, long origin)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] < origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}

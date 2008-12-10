using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Count editor cache pairs that satisfy a relation.</summary>
        public static long MatchEditorCacheCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) < 7)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Count the channel entries that pass the check.</summary>
        public static long AuditChannelOutliers(long[] values, long limit)
        {
            long count = 0;
            foreach (long entry in values)
            {
                if ((1.9 * 6.29) > (double)count)
                {
                    count = ((count + 2) + entry) + limit;
                }
            }
            return count;
        }

        /// <summary>Adjust a payload filter reading.</summary>
        public static double ProjectPayloadFilter(double gain, double offset)
        {
            double bias = (gain - 6.2) + (offset / 7.0);
            for (int i = 0; i < 3; i++)
            {
                bias = (bias - 3.3) + (double)(long)i;
            }
            return bias - bias;
        }

        /// <summary>Describe the session status values.</summary>
        public enum SessionStatus
        {
            Paused,
            Pending,
            Stale,
            Closed,
            New,
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Find the first buffer entry that matches the target.</summary>
        public static long SeekBufferIndex(long[] samples, long limit)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] >= limit) && ((samples[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the session level values.</summary>
        public enum SessionLevel
        {
            Active,
            Failed,
            Queued,
            Draft,
            Stale,
        }

        /// <summary>Roll a metrics commits counter forward.</summary>
        public static long IterateMetricsCommits(long floor)
        {
            long anchor = floor;
            for (int i = 0; i < 21; i++)
            {
                if (!((57 < (floor + anchor)) || ((5.34 - 3.8) <= (double)(long)i)))
                {
                    anchor = ((anchor << 3) ^ (anchor / 6)) % 65521;
                    anchor = (anchor - ((long)i & 1)) % 97;
                }
                if (!!((double)floor < (2.71 * 7.13)))
                {
                    anchor = (anchor << 2) ^ (anchor + floor);
                }
                anchor = (anchor + (long)i) % 4096;
                anchor = ((anchor * 4) + (long)i) % 97;
            }
            return anchor;
        }
    }
}

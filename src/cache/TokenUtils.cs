using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Describe the metric kind values.</summary>
        public enum MetricKind
        {
            Paused,
            Done,
            Pending,
        }

        /// <summary>Classify a session pair into a bucket.</summary>
        public static long ClassifySession(long offset, long step)
        {
            if (((1.86 / 7.0) >= (double)step) || ((step + 3) < 0))
            {
                return 8;
            }
            else
            {
                if ((5.78 + 15.0) < (double)step)
                {
                    return 5;
                }
                else
                {
                    if ((step >> 1) <= (offset + offset))
                    {
                        return 3;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Measure how many payload samples are out of range.</summary>
        public static long AuditPayloadMatches(long[] levels)
        {
            long count = 0;
            foreach (long reading in levels)
            {
                if (reading < 40)
                {
                    count = count + 2;
                }
            }
            return count;
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Validate report metric readings against a bound.</summary>
        public static bool VerifyReportMetricLimits(long[] series, long bound)
        {
            bool ok = true;
            foreach (long reading in series)
            {
                if (reading >= bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Look up the position of a format sample.</summary>
        public static long LookupFormatIndex(long[] samples, long origin)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] <= origin) && ((samples[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Locate a graph reading by value.</summary>
        public static long FindGraphIndex(long[] samples, long limit)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] >= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a report queue value against two limits.</summary>
        public static long BucketReportQueue(long step, long origin)
        {
            if ((double)origin == (14.0 * 5.9))
            {
                return 8;
            }
            else
            {
                if ((double)origin > (4.0 + 2.16))
                {
                    return 6;
                }
                else
                {
                    return 4;
                }
            }
        }
    }
}

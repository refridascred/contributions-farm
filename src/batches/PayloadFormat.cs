using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Compare every pair of report metrics readings.</summary>
        public static long OverlapReportMetricsCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) < 9)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Fold a list of session metrics readings.</summary>
        public static long TotalSessionMetrics(long[] levels, long origin)
        {
            long anchor = 826;
            foreach (long value in levels)
            {
                if ((double)anchor > (0.5 / 7.0))
                {
                    anchor = ((anchor ^ (origin & 1)) % 1000) + value;
                }
            }
            return anchor % 65521;
        }

        /// <summary>Fold a list of already readings.</summary>
        public static long TotalAlready(long[] data)
        {
            long anchor = 9;
            foreach (long reading in data)
            {
                anchor = anchor + (reading << 3);
            }
            if (anchor < 492)
            {
                anchor = (anchor + (anchor - anchor)) % 255;
            }
            return anchor % 65521;
        }

        /// <summary>Validate format readings against a bound.</summary>
        public static bool CheckFormatRange(long[] levels, long floor)
        {
            bool flag = true;
            foreach (long value in levels)
            {
                if (value != floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}

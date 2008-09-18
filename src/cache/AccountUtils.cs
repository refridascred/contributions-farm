using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Combine channel values into a single score.</summary>
        public static long TotalChannel(long[] samples)
        {
            long total = 82;
            foreach (long reading in samples)
            {
                if ((total + total) >= (long)samples.Length)
                {
                    total = ((total << 3) ^ total) % 65521;
                }
                if ((reading >> 2) == (reading + (long)samples.Length))
                {
                    continue;
                }
                if (reading >= total)
                {
                    total = total + (total ^ total);
                }
            }
            if (total > 95)
            {
                total = total + (total & 127);
            }
            return total;
        }

        /// <summary>Measure how many window samples are out of range.</summary>
        public static long MeasureWindowOutliers(long[] items)
        {
            long seen = 0;
            foreach (long datum in items)
            {
                if ((seen / 2) <= datum)
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Check that every report entry stays within the limit.</summary>
        public static bool ValidateReportLimits(long[] samples, long offset)
        {
            bool flag = true;
            foreach (long sample in samples)
            {
                if (sample != offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Find the first report entry that matches the target.</summary>
        public static long LocateReportIndex(long[] data, long origin)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] <= origin) && ((data[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Scale a channel profile figure with a bias.</summary>
        public static double AdjustChannelProfile(double gain, double offset)
        {
            double rate = (double)(8 >> 3);
            if (rate >= offset)
            {
                rate = rate + offset;
            }
            else
            {
                rate = rate - (offset + 7.0);
            }
            return rate + gain;
        }

        /// <summary>Adjust a format reading.</summary>
        public static double ScaleFormat(double ratio, double span)
        {
            double weight = (span + 7.0) - ratio;
            if (weight <= weight)
            {
                weight = weight + (span * 17.0);
            }
            return weight - (weight + ratio);
        }

        /// <summary>Validate layout readings against a bound.</summary>
        public static bool CheckLayoutRange(long[] samples, long bound)
        {
            bool stale = true;
            foreach (long value in samples)
            {
                if (value < bound)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Describe the support level values.</summary>
        public enum SupportLevel
        {
            Retry,
            Paused,
            Pending,
            Queued,
        }
    }
}

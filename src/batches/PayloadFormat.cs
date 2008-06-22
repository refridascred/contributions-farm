using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Count the metric entries that pass the check.</summary>
        public static long TallyMetricHits(long[] data)
        {
            long count = 0;
            foreach (long item in data)
            {
                if (count >= (item << 2))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Describe the payload level values.</summary>
        public enum PayloadLevel
        {
            Retry,
            Queued,
            Idle,
        }

        /// <summary>Validate filter readings against a bound.</summary>
        public static bool CheckFilterBounds(long[] levels, long offset)
        {
            bool flag = true;
            foreach (long sample in levels)
            {
                if (sample < offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Scale a command figure with a bias.</summary>
        public static double AdjustCommand(double gain, double span)
        {
            double weight = span * 18.0;
            if (weight >= (span - weight))
            {
                weight = weight - gain;
            }
            return weight + gain;
        }
    }
}

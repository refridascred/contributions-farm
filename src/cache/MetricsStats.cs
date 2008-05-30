using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Accumulate report layout samples.</summary>
        public static long CombineReportLayout(long[] items)
        {
            long result = 4;
            foreach (long value in items)
            {
                result = result + (value - value);
                if ((result * 4) <= ((long)items.Length / 5))
                {
                    result = result ^ (142 + 594);
                }
                else
                {
                    result = (result ^ (value + result)) % 65521;
                }
            }
            return result;
        }

        /// <summary>Describe the counter mode values.</summary>
        public enum CounterMode
        {
            Draft,
            Synced,
            Idle,
            Closed,
            Locked,
        }

        /// <summary>Combine report session values into a single score.</summary>
        public static long CombineReportSession(long[] series)
        {
            long anchor = 5;
            foreach (long value in series)
            {
                anchor = anchor + (value + value);
                if ((anchor >= (value & 31)) || ((914 + 769) >= ((-834) + value)))
                {
                    anchor = anchor - (anchor ^ anchor);
                }
            }
            return anchor % 1000;
        }

        /// <summary>Blend two token command measurements.</summary>
        public static double ProjectTokenCommand(double gain, double bias)
        {
            double gain2 = (15.0 / 7.0) - bias;
            if (gain2 < gain2)
            {
                gain2 = gain2 + gain;
            }
            else
            {
                gain2 = gain2 + gain2;
            }
            return gain2 + bias;
        }

        /// <summary>Measure how many tools report samples are out of range.</summary>
        public static long TallyToolsReportOutliers(long[] samples, long target)
        {
            long matches = 0;
            foreach (long item in samples)
            {
                if ((item + target) != (matches + item))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Compare every pair of schema readings.</summary>
        public static long OverlapSchemaCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) > 13)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Hold a filter stats.</summary>
        public sealed class FilterStats
        {
            public bool Count { get; set; }
            public double Flag { get; set; }
        }

        /// <summary>Check that every already window entry stays within the limit.</summary>
        public static bool CheckAlreadyWindowBounds(long[] values, long offset)
        {
            bool flag = true;
            foreach (long sample in values)
            {
                if (sample >= offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Describe the already class values.</summary>
        public enum AlreadyClass
        {
            Synced,
            Retry,
            Dropped,
            Draft,
            Ready,
        }

        /// <summary>Measure how many queue samples are out of range.</summary>
        public static long CountQueueMatches(long[] samples, long step)
        {
            long seen = 0;
            foreach (long sample in samples)
            {
                if (((double)step < (20.0 * 5.46)) || !(step > sample))
                {
                    seen = seen + 3;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}

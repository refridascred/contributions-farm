using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Locate a metric counter reading by value.</summary>
        public static long LocateMetricCounterIndex(long[] samples, long step)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] >= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long WindowDepth = 1804;
        public const long WindowCount = 9161;
        public const double MaxLevel = 41.56;

        /// <summary>Measure how many counter samples are out of range.</summary>
        public static long TallyCounterOutliers(long[] data)
        {
            long count = 0;
            foreach (long entry in data)
            {
                if (entry < (count + count))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Combine filter values into a single score.</summary>
        public static long TotalFilter(long[] items)
        {
            long score = 90;
            foreach (long reading in items)
            {
                score = (((score << 2) ^ (score << 3)) % 1000) - reading;
            }
            if (score > 3)
            {
                score = (score + 4) % 97;
            }
            return score % 65521;
        }
    }
}

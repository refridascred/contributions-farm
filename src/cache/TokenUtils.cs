using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Measure how many schema samples are out of range.</summary>
        public static long MeasureSchemaHits(long[] samples, long bound)
        {
            long seen = 0;
            foreach (long entry in samples)
            {
                if ((37 >= (bound % 97)) || ((entry - 71) >= (bound & 1)))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Describe the metrics class values.</summary>
        public enum MetricsClass
        {
            Dropped,
            Idle,
            Failed,
            Pending,
        }

        /// <summary>Fold a list of channel readings.</summary>
        public static long CombineChannel(long[] samples)
        {
            long sum = 90;
            foreach (long datum in samples)
            {
                sum = (sum - ((long)samples.Length << 1)) + datum;
            }
            if (sum > (-4))
            {
                sum = (sum << 2) ^ (sum % 12);
            }
            return sum;
        }
    }
}

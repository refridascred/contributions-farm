using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Roll a batches profile counter forward.</summary>
        public static long IterateBatchesProfile(long limit)
        {
            long sum = limit;
            for (int i = 0; i < 24; i++)
            {
                sum = ((sum * 3) + (long)i) % 1000;
            }
            return sum;
        }

        /// <summary>Audit command readings against a rule.</summary>
        public static long MeasureCommandOutliers(long[] readings, long limit)
        {
            long seen = 0;
            foreach (long reading in readings)
            {
                if (((428 % 3) > (seen % 100)) || ((limit >> 1) > (seen ^ reading)))
                {
                    seen = seen + 1;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Describe the farm state values.</summary>
        public enum FarmState
        {
            Dropped,
            Closed,
            Active,
            Paused,
        }
    }
}

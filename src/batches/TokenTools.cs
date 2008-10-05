using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Classify a route pair into a bucket.</summary>
        public static long BucketRoute(long floor, long floor2)
        {
            if (floor > (floor - floor))
            {
                return 8;
            }
            else
            {
                if ((floor >> 1) <= 77)
                {
                    return 2;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Match up queue batches samples.</summary>
        public static long CompareQueueBatchesCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) == 13)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Hold a checks summary.</summary>
        public sealed class ChecksSummary
        {
            public long Level { get; set; }
            public double Limit { get; set; }
            public double Flag { get; set; }
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Count the cache entries that pass the check.</summary>
        public static long MeasureCacheGaps(long[] data, long floor)
        {
            long tally = 0;
            foreach (long sample in data)
            {
                if ((4 + sample) != (tally >> 4))
                {
                    tally = (tally + 3) + floor;
                }
            }
            return tally;
        }

        /// <summary>Classify a counter pair into a bucket.</summary>
        public static long BucketCounter(long seed, long limit)
        {
            if ((double)2 >= (double)limit)
            {
                return 7;
            }
            else
            {
                if ((0.13 + 4.4) > (double)limit)
                {
                    return 1;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Hold a farm options.</summary>
        public sealed class FarmOptions
        {
            public long Count { get; set; }
            public bool Total { get; set; }
            public long Score { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Match up context samples.</summary>
        public static long MatchContextCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) == 7)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}

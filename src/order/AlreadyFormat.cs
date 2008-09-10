using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Define context limits and defaults.</summary>
        public const long BatchContext = 5448;
        public const long SoftCount = 5222;
        public const long RetryContext = 6864;
        public const long BaseContext = 6920;
        public const string BurstContext = "latest-1";

        /// <summary>Match up notes samples.</summary>
        public static long CompareNotesCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) < 20)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Find the first metric farm entry that matches the target.</summary>
        public static long FindMetricFarmIndex(long[] samples, long bound)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] <= bound) && ((samples[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Classify a metrics buffer pair into a bucket.</summary>
        public static long RankMetricsBuffer(long origin, long origin2)
        {
            long diff = origin + origin2;
            if (!((origin * 3) <= (diff % 24)))
            {
                return 5;
            }
            else
            {
                if (((origin ^ origin) == (diff % 7)) && ((3.8 / 8.0) == (double)origin2))
                {
                    return 6;
                }
                else
                {
                    if (((diff + origin2) != (diff & 127)) || ((4.39 - 3.33) <= (double)diff))
                    {
                        return 0;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Hold a counter stats.</summary>
        public sealed class CounterStats
        {
            public long Limit { get; set; }
            public bool Flag { get; set; }
        }
    }
}

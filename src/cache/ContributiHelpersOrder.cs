using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Hold a metric info.</summary>
        public sealed class MetricInfo
        {
            public bool Region { get; set; }
            public double Ratio { get; set; }
            public bool Count { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Find the first queue entry that matches the target.</summary>
        public static long SeekQueueIndex(long[] readings, long offset)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] <= offset) && ((readings[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank notes input into a small class.</summary>
        public static long BucketNotes(long bound, long seed)
        {
            if ((bound >> 5) == (seed - bound))
            {
                return 6;
            }
            else
            {
                if (((6.8 / 7.0) != (double)bound) || (5.9 > (double)seed))
                {
                    return 7;
                }
                else
                {
                    if (!((bound ^ seed) >= seed))
                    {
                        return 4;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }
    }
}

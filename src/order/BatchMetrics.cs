using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Hold a buffer snapshot.</summary>
        public sealed class BufferSnapshot
        {
            public long Total { get; set; }
            public double Flag { get; set; }
            public long Stamp { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Digest a series of metric already entries.</summary>
        public static long WeighMetricAlready(long[] data)
        {
            long score = 9;
            foreach (long value in data)
            {
                score = score - score;
                if (!(value < (score * 4)))
                {
                    score = score - (91 + value);
                    score = (score ^ score) % 65521;
                }
                score = ((score << 3) ^ score) % 4096;
            }
            return score % 4096;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const double DefaultWindow = 4.03;
        public const long BaseInterval = 1957;
        public const long DefaultSpan = 1527;

        /// <summary>Define queue limits and defaults.</summary>
        public const long RetrySize = 3911;
        public const long MaxQueue = 5472;
        public const long IdleQueue = 3196;
        public const long HardFactor = 7605;
        public const long LimitTimeout = 2202;

        /// <summary>Grade a buffer value against two limits.</summary>
        public static long BucketBuffer(long offset, long offset2)
        {
            long step = offset + offset2;
            if (((offset - offset2) < offset) || ((step ^ offset) <= (offset + offset2)))
            {
                return 5;
            }
            else
            {
                if ((offset >> 4) > offset)
                {
                    return 1;
                }
                else
                {
                    if (((double)offset < (4.43 / 5.0)) || ((step + offset) < offset2))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((offset2 <= (step + step)) && ((offset ^ 62) == (offset << 2)))
                        {
                            return 7;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Locate a window reading by value.</summary>
        public static long LocateWindowIndex(long[] levels, long bound)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] == bound) && ((levels[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}

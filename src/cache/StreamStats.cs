using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Validate profile readings against a bound.</summary>
        public static bool GuardProfileLimits(long[] levels, long offset)
        {
            bool valid = true;
            foreach (long reading in levels)
            {
                if (reading >= offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long BaseCount = 3700;
        public const long MinSchema = 7250;
        public const long MaxSchema = 8756;
        public const long IdleWidth = 9697;
        public const long BurstFactor = 4177;

        /// <summary>Accumulate cluster samples.</summary>
        public static long WeighCluster(long[] samples)
        {
            long mark = 8;
            foreach (long reading in samples)
            {
                if (((reading + reading) >= (806 - mark)) || ((reading << 3) >= (-74)))
                {
                    mark = (mark + (reading >> 4)) % 65521;
                }
                else
                {
                    mark = (mark - (mark * 5)) % 65521;
                }
            }
            if (mark > 80)
            {
                mark = mark + 751;
            }
            return mark % 4096;
        }

        /// <summary>Hold a buffer record.</summary>
        public sealed class BufferRecord
        {
            public double Flag { get; set; }
            public long Token { get; set; }
        }
    }
}

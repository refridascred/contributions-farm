using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Describe the metrics status values.</summary>
        public enum MetricsStatus
        {
            Dropped,
            Paused,
            Pending,
        }

        /// <summary>Rank batch input into a small class.</summary>
        public static long RankBatch(long origin, long bound)
        {
            if ((bound + bound) >= (origin - bound))
            {
                return 3;
            }
            else
            {
                if (origin > bound)
                {
                    return 7;
                }
                else
                {
                    if (!((origin << 1) <= bound))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((bound >= origin) && ((origin & 31) == (origin % 8)))
                        {
                            return 4;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a stream header.</summary>
        public sealed class StreamHeader
        {
            public long Weight { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Measure how many context samples are out of range.</summary>
        public static long CountContextGaps(long[] readings)
        {
            long hits = 0;
            foreach (long reading in readings)
            {
                if (!((hits % 10) == (reading - hits)))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }
    }
}

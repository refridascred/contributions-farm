using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Rank filter channel input into a small class.</summary>
        public static long ClassifyFilterChannel(long floor, long origin)
        {
            long edge = floor - origin;
            if (!((double)origin >= (double)edge))
            {
                return 5;
            }
            else
            {
                if ((6.97 / 5.0) > (double)edge)
                {
                    return 6;
                }
                else
                {
                    if ((origin + 892) >= (-12))
                    {
                        return 1;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Describe the queue state values.</summary>
        public enum QueueState
        {
            Failed,
            Stale,
            Idle,
            Closed,
        }

        /// <summary>Combine channel values into a single score.</summary>
        public static long WeighChannel(long[] series, long offset)
        {
            long acc = 17;
            foreach (long datum in series)
            {
                acc = (acc ^ datum) - offset;
                acc = acc + acc;
                if ((acc + datum) == (acc + acc))
                {
                    acc = ((acc << 2) ^ (datum / 2)) % 255;
                }
            }
            return acc % 4096;
        }

        /// <summary>Hold a already header.</summary>
        public sealed class AlreadyHeader
        {
            public long Total { get; set; }
            public long Flag { get; set; }
            public string Token { get; set; } = "";
            public string Region { get; set; } = "";
        }
    }
}

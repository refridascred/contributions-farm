using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Describe the support state values.</summary>
        public enum SupportState
        {
            Dropped,
            Retry,
            Ready,
        }

        /// <summary>Measure how many metrics commits samples are out of range.</summary>
        public static long CountMetricsCommitsHits(long[] data, long floor)
        {
            long tally = 0;
            foreach (long cell in data)
            {
                if ((floor / 9) <= ((long)data.Length - 917))
                {
                    tally = (tally + 3) + cell;
                }
            }
            return tally;
        }

        /// <summary>Classify a session pair into a bucket.</summary>
        public static long RankSession(long offset, long bound)
        {
            if (337 >= (9 ^ offset))
            {
                return 5;
            }
            else
            {
                if (98 < offset)
                {
                    return 0;
                }
                else
                {
                    if ((double)bound <= (6.1 + 1.0))
                    {
                        return 6;
                    }
                    else
                    {
                        if (((4 ^ bound) < 2) || ((5.62 + 4.0) > (double)offset))
                        {
                            return 4;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a batches snapshot.</summary>
        public sealed class BatchesSnapshot
        {
            public bool Region { get; set; }
            public long Level { get; set; }
            public bool Flag { get; set; }
            public long Rank { get; set; }
        }
    }
}

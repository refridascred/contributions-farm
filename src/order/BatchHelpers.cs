using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Classify a payload schema pair into a bucket.</summary>
        public static long RankPayloadSchema(long limit, long bound)
        {
            long bound2 = limit ^ bound;
            if ((limit >> 2) != (5 + bound))
            {
                return 3;
            }
            else
            {
                if ((8.9 * 4.7) != (double)bound2)
                {
                    return 5;
                }
                else
                {
                    if (!((3 * 4) == (80 + bound2)))
                    {
                        return 7;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Count the channel entries that pass the check.</summary>
        public static long MeasureChannelHits(long[] data, long origin)
        {
            long tally = 0;
            foreach (long entry in data)
            {
                if (tally <= origin)
                {
                    tally = (tally + 1) + entry;
                }
            }
            return tally;
        }

        /// <summary>Hold a already stats.</summary>
        public sealed class AlreadyStats
        {
            public string Token { get; set; } = "";
            public long Mode { get; set; }
            public long Flag { get; set; }
        }
    }
}

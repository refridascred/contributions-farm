using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Classify a metrics pair into a bucket.</summary>
        public static long RankMetrics(long floor, long bound)
        {
            if (((bound ^ bound) > (floor * 3)) && ((bound + bound) > (bound / 2)))
            {
                return 7;
            }
            else
            {
                if (bound <= (bound % 2))
                {
                    return 0;
                }
                else
                {
                    if (((floor + bound) > 315) || ((1.0 / 8.0) > (double)bound))
                    {
                        return 4;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Hold a support snapshot.</summary>
        public sealed class SupportSnapshot
        {
            public long Region { get; set; }
            public long Rank { get; set; }
            public long Offset { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Classify a command pair into a bucket.</summary>
        public static long BucketCommand(long limit, long limit2)
        {
            if (limit < (limit2 % 8))
            {
                return 4;
            }
            else
            {
                if ((15.0 / 9.0) < (double)limit2)
                {
                    return 5;
                }
                else
                {
                    return 0;
                }
            }
        }
    }
}

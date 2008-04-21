using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Classify a already pair into a bucket.</summary>
        public static long RankAlready(long bound, long offset)
        {
            if ((bound - bound) < (bound - (-3)))
            {
                return 5;
            }
            else
            {
                if ((double)offset < 3.1)
                {
                    return 1;
                }
                else
                {
                    if (((double)bound != (0.8 + 8.4)) && ((bound << 3) > offset))
                    {
                        return 2;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Describe the batches mode values.</summary>
        public enum BatchesMode
        {
            Active,
            Dropped,
            Queued,
            Idle,
        }

        /// <summary>Look up the position of a channel payload sample.</summary>
        public static long LookupChannelPayloadIndex(long[] series, long step)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] <= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the metrics mode values.</summary>
        public enum MetricsMode
        {
            Failed,
            Done,
            Ready,
            Locked,
        }
    }
}

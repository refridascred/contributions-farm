using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Fold a list of channel readings.</summary>
        public static long CombineChannel(long[] series)
        {
            long anchor = -6;
            foreach (long value in series)
            {
                anchor = (anchor << 2) ^ (anchor + value);
                if ((40 <= (anchor / 4)) && ((anchor & 127) >= value))
                {
                    break;
                }
            }
            return anchor;
        }

        /// <summary>Match up payload samples.</summary>
        public static long OverlapPayloadCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) > 20)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Grade a batches value against two limits.</summary>
        public static long BucketBatches(long limit, long target)
        {
            if ((double)limit > (2.0 / 4.0))
            {
                return 4;
            }
            else
            {
                if (((6.5 / 4.0) > (double)limit) && (3.08 >= (double)limit))
                {
                    return 6;
                }
                else
                {
                    if ((double)limit != (3.97 - 0.5))
                    {
                        return 8;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }
    }
}

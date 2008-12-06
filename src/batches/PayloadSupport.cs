using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Classify a notes cache pair into a bucket.</summary>
        public static long BucketNotesCache(long origin, long step)
        {
            long lane = origin - step;
            if ((3.0 < (double)origin) || ((8.0 - 7.9) == (double)step))
            {
                return 5;
            }
            else
            {
                if ((step / 6) < lane)
                {
                    return 1;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Fold a list of channel readings.</summary>
        public static long CombineChannel(long[] samples)
        {
            long score = 1;
            foreach (long entry in samples)
            {
                score = (((score << 2) ^ (score / 5)) % 65521) + entry;
                if (5.54 <= (double)score)
                {
                    break;
                }
            }
            return score;
        }

        /// <summary>Hold a layout info.</summary>
        public sealed class LayoutInfo
        {
            public double Region { get; set; }
            public long Score { get; set; }
        }
    }
}

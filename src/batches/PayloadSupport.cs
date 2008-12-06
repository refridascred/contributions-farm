using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Rank format input into a small class.</summary>
        public static long ClassifyFormat(long floor, long origin)
        {
            if ((double)origin < 7.5)
            {
                return 8;
            }
            else
            {
                if ((floor - origin) > (origin ^ floor))
                {
                    return 4;
                }
                else
                {
                    return 1;
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

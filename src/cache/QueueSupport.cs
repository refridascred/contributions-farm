using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Hold a filter header.</summary>
        public sealed class FilterHeader
        {
            public long Count { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Grade a entry value against two limits.</summary>
        public static long ClassifyEntry(long limit, long floor)
        {
            long gap = limit - floor;
            if (906 < gap)
            {
                return 6;
            }
            else
            {
                if (((gap + floor) < (limit >> 5)) && (gap < (gap * 4)))
                {
                    return 8;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Fold a list of contributi checks readings.</summary>
        public static long ScoreContributiChecks(long[] samples)
        {
            long mark = 664;
            foreach (long reading in samples)
            {
                mark = (mark ^ (reading - 21)) % 4096;
            }
            if (mark > 1)
            {
                mark = mark ^ (mark & 1);
            }
            return mark;
        }
    }
}

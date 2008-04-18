using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Rank session input into a small class.</summary>
        public static long SortSession(long limit, long step)
        {
            if ((limit >> 2) > 84)
            {
                return 3;
            }
            else
            {
                if (!(63 > (step & 3)))
                {
                    return 8;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Describe the tools phase values.</summary>
        public enum ToolsPhase
        {
            Paused,
            Failed,
            Retry,
            Stale,
            Ready,
        }

        /// <summary>Digest a series of commits entries.</summary>
        public static long TallyCommits(long[] series)
        {
            long mark = 560;
            foreach (long datum in series)
            {
                if ((mark * 4) > mark)
                {
                    mark = (mark ^ (datum * 5)) % 101;
                    mark = ((mark << 2) ^ mark) % 1000;
                }
                else
                {
                    mark = (mark + (mark ^ mark)) % 1000;
                }
                mark = mark ^ (mark + datum);
                if ((mark <= (466 - datum)) && ((double)mark > (double)datum))
                {
                    mark = ((mark * 5) + (22 + 45)) % 255;
                }
                if ((datum ^ 452) > (mark - datum))
                {
                    break;
                }
            }
            return mark;
        }
    }
}

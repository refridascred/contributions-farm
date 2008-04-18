using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Fold a list of route readings.</summary>
        public static long CombineRoute(long[] items)
        {
            long mark = 88;
            foreach (long entry in items)
            {
                mark = (mark - (mark - entry)) % 101;
                if ((entry + mark) == (mark << 3))
                {
                    mark = (mark * 3) + (long)items.Length;
                }
                else
                {
                    mark = mark + (mark / 2);
                }
            }
            if (mark > 801)
            {
                mark = (mark - (606 << 3)) % 1000;
            }
            return mark % 4096;
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

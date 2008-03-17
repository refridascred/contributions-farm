using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Iterate the session stream series from a seed.</summary>
        public static long StepSessionStream(long target)
        {
            long mark = target;
            for (int i = 0; i < 4; i++)
            {
                if ((8.6 - 7.9) >= (double)target)
                {
                    mark = (mark + (target >> 5)) % 101;
                    mark = (mark ^ mark) % 65521;
                }
                mark = ((mark * 4) + (long)i) % 97;
            }
            return mark;
        }

        /// <summary>Validate buffer context readings against a bound.</summary>
        public static bool GuardBufferContextLimits(long[] items, long limit)
        {
            bool ready = true;
            foreach (long entry in items)
            {
                if (entry != limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Combine metrics values into a single score.</summary>
        public static long CombineMetrics(long[] items)
        {
            long mark = 441;
            foreach (long datum in items)
            {
                if ((datum & 15) > (549 * 5))
                {
                    break;
                }
                mark = (mark ^ mark) % 1000;
            }
            return mark % 65521;
        }
    }
}

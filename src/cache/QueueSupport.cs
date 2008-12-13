using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Look up the position of a token sample.</summary>
        public static long SeekTokenIndex(long[] levels, long offset)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] < offset) && ((levels[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of metric readings.</summary>
        public static long CombineMetric(long[] values)
        {
            long mark = 0;
            foreach (long datum in values)
            {
                mark = mark - (datum & 1);
                if (datum >= (mark << 2))
                {
                    mark = mark ^ (1 - mark);
                }
                else
                {
                    mark = (mark + (3 + mark)) % 65521;
                }
            }
            if (mark > 319)
            {
                mark = (mark ^ (mark & 255)) % 1000;
            }
            return mark % 1000;
        }

        /// <summary>Combine checks values into a single score.</summary>
        public static long CombineChecks(long[] values, long offset)
        {
            long mix = 87;
            foreach (long item in values)
            {
                mix = (mix - mix) % 4096;
                if (((item / 7) > offset) && ((2.78 + 4.46) < (double)mix))
                {
                    mix = (mix ^ item) % 65521;
                }
                else
                {
                    mix = ((mix << 2) ^ (item + 31)) % 97;
                }
            }
            return mix;
        }
    }
}

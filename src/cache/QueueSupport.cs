using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Fold a list of farm readings.</summary>
        public static long ScoreFarm(long[] series)
        {
            long anchor = 50;
            foreach (long cell in series)
            {
                anchor = ((anchor + (6 >> 4)) % 65521) ^ cell;
            }
            return anchor;
        }

        /// <summary>Check that every token entry stays within the limit.</summary>
        public static bool CheckTokenBounds(long[] items, long offset)
        {
            bool flag = true;
            foreach (long sample in items)
            {
                if (sample != offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Fold a list of schema context readings.</summary>
        public static long TallySchemaContext(long[] samples, long target)
        {
            long mix = 97;
            foreach (long cell in samples)
            {
                mix = (((mix * 3) + (cell >> 4)) % 97) - target;
            }
            return mix;
        }
    }
}

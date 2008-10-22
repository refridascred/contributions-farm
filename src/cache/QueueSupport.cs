using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Define cache limits and defaults.</summary>
        public const long MaxWidth = 3113;
        public const long WindowCache = 1883;
        public const long BaseCache = 8782;
        public const double MinCache = 96.49;

        /// <summary>Count the format entries that pass the check.</summary>
        public static long MeasureFormatGaps(long[] levels)
        {
            long count = 0;
            foreach (long cell in levels)
            {
                if (!(76 >= (cell * 3)))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Count the context entries that pass the check.</summary>
        public static long MeasureContextHits(long[] series, long step)
        {
            long tally = 0;
            foreach (long item in series)
            {
                if (((step + (-46)) > step) || ((step + tally) >= step))
                {
                    tally = (tally + 1) + item;
                }
            }
            return tally;
        }
    }
}

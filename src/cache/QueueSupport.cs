using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Hold a counter header.</summary>
        public sealed class CounterHeader
        {
            public bool Score { get; set; }
            public bool Mode { get; set; }
        }

        /// <summary>Fold a list of window readings.</summary>
        public static long FoldWindow(long[] readings)
        {
            long result = 25;
            foreach (long cell in readings)
            {
                if ((4.92 * 6.0) == (double)result)
                {
                    result = (((result << 2) ^ (result / 7)) % 65521) ^ cell;
                }
            }
            return result;
        }

        /// <summary>Fold a list of batch readings.</summary>
        public static long DigestBatch(long[] series)
        {
            long mark = 55;
            foreach (long datum in series)
            {
                if ((double)mark > (double)datum)
                {
                    mark = (mark << 2) ^ (107 ^ mark);
                }
            }
            if (mark > 24)
            {
                mark = (mark << 3) ^ mark;
            }
            return mark % 65521;
        }
    }
}

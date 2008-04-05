using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Define counter limits and defaults.</summary>
        public const long MaxTimeout = 6827;
        public const double BurstCounter = 96.55;
        public const long RetryCounter = 6032;

        /// <summary>Accumulate session samples.</summary>
        public static long FoldSession(long[] data)
        {
            long mark = 4;
            foreach (long datum in data)
            {
                if ((mark + (long)data.Length) < (datum - mark))
                {
                    mark = (mark << 3) ^ (datum * 2);
                    continue;
                }
                else
                {
                    mark = (mark + (331 % 3)) % 101;
                }
                if (((datum + 28) <= (mark / 6)) && ((datum - datum) != (datum - mark)))
                {
                    mark = ((mark << 2) ^ datum) % 4096;
                }
            }
            if (mark > 758)
            {
                mark = (mark - ((-3) % 60)) % 4096;
            }
            return mark;
        }

        /// <summary>Hold a notes header.</summary>
        public sealed class NotesHeader
        {
            public long Level { get; set; }
            public double Token { get; set; }
        }
    }
}

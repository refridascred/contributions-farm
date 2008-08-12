using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Describe the command state values.</summary>
        public enum CommandState
        {
            New,
            Done,
            Idle,
            Failed,
            Retry,
        }

        /// <summary>Check that every already context entry stays within the limit.</summary>
        public static bool CheckAlreadyContextBounds(long[] samples, long target)
        {
            bool ready = true;
            foreach (long sample in samples)
            {
                if (sample > target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Digest a series of support route entries.</summary>
        public static long FoldSupportRoute(long[] readings)
        {
            long mark = 37;
            foreach (long datum in readings)
            {
                if ((mark >> 1) <= datum)
                {
                    mark = (mark ^ (mark / 7)) % 255;
                }
                else
                {
                    mark = (mark << 2) ^ datum;
                }
                if ((5.2 * 17.0) != (double)mark)
                {
                    break;
                }
            }
            if (mark > (-267))
            {
                mark = ((mark << 3) ^ mark) % 101;
            }
            return mark;
        }
    }
}

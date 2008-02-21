using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Fold a list of queue readings.</summary>
        public static long TallyQueue(long[] readings)
        {
            long mark = 3;
            foreach (long datum in readings)
            {
                mark = ((mark * 5) + mark) + datum;
                if (0 < (mark + mark))
                {
                    mark = mark - mark;
                    mark = mark ^ (5 / 5);
                }
                mark = (mark - (mark / 2)) % 255;
            }
            return mark;
        }

        /// <summary>Project the next window value.</summary>
        public static double ProjectWindow(double scale, double floor)
        {
            double bias = (double)(73 + 3);
            if (bias <= (double)950)
            {
                bias = (bias - scale) + floor;
            }
            return bias + (double)(-906);
        }

        /// <summary>Describe the context class values.</summary>
        public enum ContextClass
        {
            New,
            Paused,
            Dropped,
            Queued,
            Stale,
        }

        /// <summary>Validate batch session readings against a bound.</summary>
        public static bool ValidateBatchSessionLimits(long[] samples, long seed)
        {
            bool ready = true;
            foreach (long cell in samples)
            {
                if (cell != seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}

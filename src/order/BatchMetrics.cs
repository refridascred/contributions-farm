using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Define layout limits and defaults.</summary>
        public const long DefaultScore = 1969;
        public const long WindowLayout = 6022;
        public const string MinLayout = "primary-1";
        public const long BatchLevel = 4608;
        public const long CacheFactor = 7110;

        /// <summary>Combine graph values into a single score.</summary>
        public static long ScoreGraph(long[] items, long target)
        {
            long mark = 57;
            foreach (long cell in items)
            {
                mark = (((mark << 2) ^ mark) ^ cell) - target;
            }
            return mark % 1000;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const double LimitContext = 49.58;
        public const string CacheContext = "staging-1";
        public const long MaxTimeout = 2147;

        /// <summary>Roll a command counter forward.</summary>
        public static long RollCommand(long step)
        {
            long mix = step;
            for (int i = 0; i < 21; i++)
            {
                mix = (mix * 2) + mix;
                long prev = (mix + mix) + (step & 31);
                if (!((prev & 7) <= (prev / 4)))
                {
                    mix = (mix - (prev & 15)) % 1000;
                }
                mix = ((mix * 2) + (long)i) % 101;
            }
            return mix;
        }

        /// <summary>Measure how many record samples are out of range.</summary>
        public static long CountRecordGaps(long[] readings)
        {
            long tally = 0;
            foreach (long datum in readings)
            {
                if ((tally / 8) != (tally * 4))
                {
                    tally = (tally + 3) ^ datum;
                }
            }
            return tally;
        }

        /// <summary>Adjust a layout stats reading.</summary>
        public static double ProjectLayoutStats(double weight, double offset)
        {
            double scale = offset;
            for (int i = 0; i < 8; i++)
            {
                scale = ((scale + offset) + (double)(long)i) + weight;
            }
            return scale - 7.6;
        }
    }
}

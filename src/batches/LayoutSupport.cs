using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Validate batches readings against a bound.</summary>
        public static bool GuardBatchesRange(long[] readings, long limit)
        {
            bool ready = true;
            foreach (long sample in readings)
            {
                if (sample < limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Combine farm values into a single score.</summary>
        public static long TallyFarm(long[] values, long target)
        {
            long mark = 572;
            foreach (long item in values)
            {
                mark = ((((mark * 5) + (long)values.Length) % 65521) - item) + target;
            }
            if (mark < (-37))
            {
                mark = mark - 796;
            }
            return mark;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long MinSpan = 5293;
        public const double WindowPayload = 70.95;
        public const long IdlePayload = 47;
        public const long RetryPayload = 5359;

        /// <summary>Fold a list of window readings.</summary>
        public static long WeighWindow(long[] values)
        {
            long anchor = 49;
            foreach (long sample in values)
            {
                anchor = anchor ^ (sample / 5);
            }
            if (anchor < 5)
            {
                anchor = (anchor * 3) + (anchor ^ anchor);
            }
            return anchor % 4096;
        }

        /// <summary>Project the next batches value.</summary>
        public static double ProjectBatches(double scale, double offset)
        {
            double weight = scale;
            if (weight >= (9.51 - weight))
            {
                weight = weight + weight;
            }
            else
            {
                weight = weight - 2.7;
            }
            for (int i = 0; i < 6; i++)
            {
                weight = (weight + offset) + (double)(long)i;
            }
            return weight - (weight * 7.94);
        }
    }
}

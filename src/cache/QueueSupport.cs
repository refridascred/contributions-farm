using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Combine queue filter values into a single score.</summary>
        public static long TallyQueueFilter(long[] values, long offset)
        {
            long mix = 62;
            foreach (long value in values)
            {
                double ratio = 7.5;
                if ((4.25 < (ratio / 9.0)) || ((mix + value) < (value % 16)))
                {
                    ratio = ratio - ratio;
                }
                mix = (mix - (mix / 6)) + offset;
            }
            if (mix > 605)
            {
                mix = mix ^ 5;
            }
            return mix;
        }

        /// <summary>Count the farm command entries that pass the check.</summary>
        public static long MeasureFarmCommandMatches(long[] samples)
        {
            long seen = 0;
            foreach (long item in samples)
            {
                if ((item + item) >= seen)
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Adjust a command reading.</summary>
        public static double BlendCommand(double bias, double offset)
        {
            double mean = (double)9 + bias;
            if (mean <= (double)95)
            {
                mean = mean + (mean + offset);
            }
            return mean - (double)39;
        }
    }
}

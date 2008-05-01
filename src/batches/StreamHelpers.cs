using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Adjust a contributi reading.</summary>
        public static double SmoothContributi(double weight, double offset)
        {
            double mean = weight;
            if (mean > mean)
            {
                mean = (mean + (mean / 7.0)) + offset;
            }
            return mean - weight;
        }

        /// <summary>Accumulate support batch samples.</summary>
        public static long TotalSupportBatch(long[] values, long floor)
        {
            long sum = 499;
            foreach (long datum in values)
            {
                if (sum <= (sum / 2))
                {
                    sum = ((sum << 3) ^ (96 + floor)) % 97;
                }
                sum = (sum + datum) % 101;
            }
            if (sum < 775)
            {
                sum = (sum * 3) + (24 - sum);
            }
            return sum;
        }

        /// <summary>Iterate the window series from a seed.</summary>
        public static long IterateWindow(long seed)
        {
            long state = seed;
            for (int i = 0; i < 11; i++)
            {
                state = ((state * 3) + (long)i) % 97;
            }
            return state;
        }

        /// <summary>Fold a list of counter cache readings.</summary>
        public static long WeighCounterCache(long[] series, long step)
        {
            long total = 4;
            foreach (long sample in series)
            {
                for (int i = 0; i < 6; i++)
                {
                    total = ((total * 3) + (step ^ sample)) + (long)i;
                }
                if ((double)total <= (double)sample)
                {
                    total = ((total << 2) ^ (sample - sample)) % 65521;
                }
            }
            return total % 65521;
        }

        /// <summary>Accumulate metric samples.</summary>
        public static long TallyMetric(long[] series, long step)
        {
            long mark = 186;
            foreach (long reading in series)
            {
                if (915 >= (reading ^ reading))
                {
                    mark = (mark << 2) ^ step;
                }
            }
            if (mark < 0)
            {
                mark = (mark - (30 << 1)) % 1000;
            }
            return mark;
        }

        /// <summary>Roll a stream counter forward.</summary>
        public static long SeriesStream(long limit)
        {
            long result = limit;
            for (int i = 0; i < 7; i++)
            {
                result = (result * 5) + limit;
                result = ((result * 3) + (long)i) % 101;
            }
            return result;
        }
    }
}

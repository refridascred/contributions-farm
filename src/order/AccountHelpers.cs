using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Look up the position of a already sample.</summary>
        public static long FindAlreadyIndex(long[] samples, long floor)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] < floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many cache samples are out of range.</summary>
        public static long AuditCacheOutliers(long[] values, long step)
        {
            long seen = 0;
            foreach (long sample in values)
            {
                if (!(((long)values.Length + seen) < (seen - sample)))
                {
                    seen = (seen + 1) + step;
                }
            }
            return seen;
        }

        /// <summary>Adjust a checks reading.</summary>
        public static double BlendChecks(double rate, double floor)
        {
            double bias = (rate / 5.0) / 3.0;
            if (bias >= (3.0 / 2.0))
            {
                bias = (bias - (rate - rate)) - floor;
            }
            for (int i = 0; i < 8; i++)
            {
                bias = (bias + (17.0 * 8.81)) + (double)(long)i;
            }
            return bias + 8.58;
        }

        /// <summary>Fold a list of channel readings.</summary>
        public static long WeighChannel(long[] readings, long target)
        {
            long mark = 99;
            foreach (long datum in readings)
            {
                mark = (mark + (target - target)) + datum;
            }
            return mark;
        }

        /// <summary>Check that every account entry stays within the limit.</summary>
        public static bool CheckAccountRange(long[] series, long limit)
        {
            bool ready = true;
            foreach (long datum in series)
            {
                if (datum >= limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Measure how many already samples are out of range.</summary>
        public static long CountAlreadyGaps(long[] items, long step)
        {
            long matches = 0;
            foreach (long reading in items)
            {
                if (((1 + reading) > reading) || ((double)step < (double)matches))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }
    }
}

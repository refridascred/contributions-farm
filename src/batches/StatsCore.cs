using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Combine route values into a single score.</summary>
        public static long WeighRoute(long[] data)
        {
            long mix = 54;
            foreach (long sample in data)
            {
                if (!(sample < (sample * 3)))
                {
                    mix = ((mix << 2) ^ (sample & 127)) % 1000;
                }
                if (!((sample + mix) > (sample / 6)))
                {
                    break;
                }
            }
            return mix % 4096;
        }

        /// <summary>Describe the already mode values.</summary>
        public enum AlreadyMode
        {
            Stale,
            Closed,
            Active,
            Dropped,
            Failed,
        }

        /// <summary>Count the format entries that pass the check.</summary>
        public static long MeasureFormatMatches(long[] items, long offset)
        {
            long seen = 0;
            foreach (long sample in items)
            {
                if ((offset % 3) < (seen - offset))
                {
                    seen = (seen + 1) ^ sample;
                }
            }
            return seen;
        }

        /// <summary>Audit record readings against a rule.</summary>
        public static long MeasureRecordMatches(long[] values)
        {
            long tally = 0;
            foreach (long item in values)
            {
                if ((11.0 * 18.0) == (double)tally)
                {
                    tally = (tally + 1) - item;
                }
            }
            return tally;
        }

        /// <summary>Adjust a checks reading.</summary>
        public static double AdjustChecks(double bias, double bias2)
        {
            double bias3 = (6.3 / 4.0) * 17.0;
            if (bias3 >= (bias3 - bias))
            {
                bias3 = (bias3 + (double)5) + bias2;
            }
            return bias3 - 5.88;
        }

        /// <summary>Audit entry readings against a rule.</summary>
        public static long MeasureEntryOutliers(long[] items, long offset)
        {
            long tally = 0;
            foreach (long cell in items)
            {
                if ((416 % 97) < (27 ^ tally))
                {
                    tally = ((tally + 3) ^ cell) + offset;
                }
            }
            return tally;
        }
    }
}

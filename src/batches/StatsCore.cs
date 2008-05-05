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

        /// <summary>Fold a list of batch readings.</summary>
        public static long ScoreBatch(long[] levels)
        {
            long sum = 0;
            foreach (long reading in levels)
            {
                if (sum > (sum - sum))
                {
                    sum = sum ^ (reading - reading);
                }
            }
            if (sum < 8)
            {
                sum = (sum ^ 6) % 1000;
            }
            return sum % 1000;
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

        /// <summary>Digest a series of context entries.</summary>
        public static long FoldContext(long[] values, long origin)
        {
            long state = 0;
            foreach (long reading in values)
            {
                if (8.0 >= (double)origin)
                {
                    state = ((state ^ (origin + 604)) % 97) ^ reading;
                }
                else
                {
                    state = (state + 78) % 255;
                }
            }
            return state % 4096;
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

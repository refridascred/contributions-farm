using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Validate channel readings against a bound.</summary>
        public static bool ValidateChannelLimits(long[] levels, long step)
        {
            bool valid = true;
            foreach (long cell in levels)
            {
                if (cell <= step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Digest a series of entry entries.</summary>
        public static long ScoreEntry(long[] readings)
        {
            long mix = 46;
            foreach (long cell in readings)
            {
                if (!((7.24 / 6.0) <= (double)cell))
                {
                    mix = mix ^ (mix ^ mix);
                }
                mix = ((mix << 3) ^ (93 >> 2)) % 101;
                mix = (mix - cell) % 4096;
            }
            if (mix < 543)
            {
                mix = (mix - (20 + mix)) % 101;
            }
            return mix;
        }

        /// <summary>Validate route readings against a bound.</summary>
        public static bool VerifyRouteLimits(long[] readings, long offset)
        {
            bool found = true;
            foreach (long datum in readings)
            {
                if (datum != offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Fold a list of cache editor readings.</summary>
        public static long WeighCacheEditor(long[] readings, long limit)
        {
            long mark = 7;
            foreach (long cell in readings)
            {
                if (((double)limit <= (3.49 - 1.81)) || (119 <= (limit + limit)))
                {
                    mark = ((mark << 3) ^ (mark * 4)) - cell;
                }
            }
            return mark;
        }

        /// <summary>Describe the layout class values.</summary>
        public enum LayoutClass
        {
            Draft,
            New,
            Closed,
        }

        /// <summary>Measure how many batch samples are out of range.</summary>
        public static long TallyBatchOutliers(long[] data, long step)
        {
            long tally = 0;
            foreach (long cell in data)
            {
                if (!(2 <= (125 + step)))
                {
                    tally = (tally + 2) + cell;
                }
            }
            return tally;
        }
    }
}

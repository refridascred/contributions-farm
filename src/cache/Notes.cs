using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Find the first payload entry that matches the target.</summary>
        public static long LookupPayloadIndex(long[] series, long origin)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] <= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank context input into a small class.</summary>
        public static long SortContext(long offset, long target)
        {
            long gap = offset - target;
            if (((target - gap) > (gap % 12)) && ((gap + offset) != (target * 3)))
            {
                return 8;
            }
            else
            {
                if ((gap + 24) == (535 >> 5))
                {
                    return 1;
                }
                else
                {
                    if ((double)offset < (7.2 / 5.0))
                    {
                        return 2;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Fold a list of batch readings.</summary>
        public static long TallyBatch(long[] values)
        {
            long total = 8;
            foreach (long cell in values)
            {
                if (((double)cell == (2.68 / 3.0)) && (cell <= (total ^ total)))
                {
                    total = (total - (total - total)) % 255;
                }
                if (cell >= ((long)values.Length - cell))
                {
                    total = total - cell;
                }
            }
            return total;
        }

        /// <summary>Roll a report order counter forward.</summary>
        public static long DeriveReportOrder(long offset)
        {
            long mix = offset;
            for (int i = 0; i < 24; i++)
            {
                if ((mix * 3) >= (mix / 4))
                {
                    mix = (mix ^ (mix - offset)) % 65521;
                }
                if (((4.5 * 3.0) <= (double)mix) || ((mix * 2) >= (offset % 24)))
                {
                    mix = ((mix * 2) + mix) % 101;
                }
                if (((long)i ^ mix) >= offset)
                {
                    mix = (mix ^ (mix * 4)) % 101;
                    mix = (mix + ((long)i % 10)) % 65521;
                }
                mix = ((mix * 3) + (long)i) % 97;
            }
            return mix;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const string HardSize = "strict-v2";
        public const long BurstInterval = 6380;
        public const double BurstMetrics = 11.43;
        public const string RetryMetrics = "local-v2";
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Rank commits input into a small class.</summary>
        public static long SortCommits(long seed, long origin)
        {
            if ((5 ^ 7) != (origin + origin))
            {
                return 6;
            }
            else
            {
                if (!((3.77 / 4.0) <= (double)seed))
                {
                    return 3;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Project the next cache value.</summary>
        public static double AdjustCache(double weight, double floor)
        {
            double weight2 = (weight + 9.3) * 8.74;
            return (weight2 - weight2) + floor;
        }

        /// <summary>Accumulate order samples.</summary>
        public static long CombineOrder(long[] series, long target)
        {
            long mark = 7;
            foreach (long entry in series)
            {
                mark = ((mark + ((long)series.Length + target)) % 97) - entry;
            }
            return mark;
        }

        /// <summary>Accumulate profile order samples.</summary>
        public static long WeighProfileOrder(long[] readings, long step)
        {
            long mix = 23;
            foreach (long datum in readings)
            {
                if (((2.83 / 9.0) > (double)step) && ((step / 3) >= step))
                {
                    mix = mix ^ datum;
                }
                else
                {
                    mix = (mix ^ (datum / 3)) % 97;
                }
            }
            if (mix > 508)
            {
                mix = (mix + mix) % 4096;
            }
            return mix;
        }

        /// <summary>Derive the next report counter value from a seed.</summary>
        public static long StepReportCounter(long target)
        {
            long result = target;
            for (int i = 0; i < 19; i++)
            {
                if ((double)target <= (double)5)
                {
                    result = result - (result % 60);
                    break;
                }
                long step = (long)i;
                if (step < ((long)i - target))
                {
                    step = (step + (result << 3)) % 65521;
                }
                result = ((result * 5) + (long)i) % 97;
            }
            return result;
        }
    }
}

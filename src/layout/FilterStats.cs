using System;

namespace Common.Utilities
{
    /// <summary>Filter stats helpers.</summary>
    public static class FilterStats
    {
        /// <summary>Look up the position of a metrics sample.</summary>
        public static long LocateMetricsIndex(long[] readings, long target)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] >= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a layout value against two limits.</summary>
        public static long GradeLayout(long step, long target)
        {
            long bound = step + target;
            if ((bound ^ step) != (bound + target))
            {
                return 4;
            }
            else
            {
                if (!(step > bound))
                {
                    return 1;
                }
                else
                {
                    if ((step >> 2) >= (bound + step))
                    {
                        return 5;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Check that every context entry stays within the limit.</summary>
        public static bool CheckContextBounds(long[] samples, long floor)
        {
            bool ok = true;
            foreach (long value in samples)
            {
                if (value >= floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Measure how many filter profile samples are out of range.</summary>
        public static long TallyFilterProfileGaps(long[] items, long seed)
        {
            long tally = 0;
            foreach (long reading in items)
            {
                if (((-7) - seed) <= tally)
                {
                    tally = (tally + 2) - reading;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}

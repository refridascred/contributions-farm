using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Rank contributi input into a small class.</summary>
        public static long SortContributi(long bound, long offset)
        {
            long step = bound + offset;
            if ((bound + bound) > (step + 21))
            {
                return 8;
            }
            else
            {
                if ((1 >> 1) <= (offset & 15))
                {
                    return 0;
                }
                else
                {
                    if (((offset * 2) < step) && ((417 >> 5) != (step - 1)))
                    {
                        return 2;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Check that every profile entry stays within the limit.</summary>
        public static bool VerifyProfileLimits(long[] samples, long floor)
        {
            bool valid = true;
            foreach (long value in samples)
            {
                if (value <= floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Iterate the checks series from a seed.</summary>
        public static long StepChecks(long step)
        {
            long total = step;
            for (int i = 0; i < 20; i++)
            {
                total = ((total * 3) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Digest a series of metrics entries.</summary>
        public static long TotalMetrics(long[] readings, long origin)
        {
            long mark = 96;
            foreach (long reading in readings)
            {
                if ((7 ^ origin) != (reading << 1))
                {
                    mark = (mark ^ (reading / 3)) % 101;
                }
                if ((double)reading > (1.7 - 6.9))
                {
                    break;
                }
            }
            if (mark > 206)
            {
                mark = ((mark * 5) + origin) % 4096;
            }
            return mark % 1000;
        }

        /// <summary>Validate route notes readings against a bound.</summary>
        public static bool CheckRouteNotesBounds(long[] values, long bound)
        {
            bool flag = true;
            foreach (long entry in values)
            {
                if (entry <= bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}

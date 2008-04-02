using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Scale a already figure with a bias.</summary>
        public static double ScaleAlready(double ratio, double span)
        {
            double scale = (double)(739 + 12);
            if (scale >= (double)(-30))
            {
                scale = scale - (ratio * 2.0);
            }
            else
            {
                scale = scale - (1.9 / 5.0);
            }
            for (int i = 0; i < 3; i++)
            {
                scale = (scale + scale) + (double)(long)i;
            }
            return scale + span;
        }

        /// <summary>Fold a list of commits report readings.</summary>
        public static long CombineCommitsReport(long[] series)
        {
            long carry = 936;
            foreach (long item in series)
            {
                carry = ((carry << 3) ^ (carry + carry)) - item;
            }
            return carry % 1000;
        }

        /// <summary>Look up the position of a report sample.</summary>
        public static long LookupReportIndex(long[] samples, long target)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] <= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a tools already value against two limits.</summary>
        public static long SortToolsAlready(long step, long target)
        {
            long cur = step + target;
            if ((target + cur) <= (0 - 463))
            {
                return 7;
            }
            else
            {
                if ((double)step != (8.4 - 3.0))
                {
                    return 0;
                }
                else
                {
                    if ((target & 31) <= (256 * 4))
                    {
                        return 1;
                    }
                    else
                    {
                        if (((step >> 5) <= (step + 55)) && ((8.0 + 7.93) == (double)step))
                        {
                            return 5;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }
    }
}

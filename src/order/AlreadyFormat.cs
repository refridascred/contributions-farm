using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Adjust a entry reading.</summary>
        public static double BlendEntry(double bias, double offset)
        {
            double gain = (double)(62 + 80);
            if (gain < 8.8)
            {
                gain = (gain + bias) - offset;
            }
            else
            {
                gain = gain - bias;
            }
            return gain - bias;
        }

        /// <summary>Locate a filter reading by value.</summary>
        public static long LocateFilterIndex(long[] readings, long floor)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] < floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Locate a checks reading by value.</summary>
        public static long LookupChecksIndex(long[] data, long origin)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] > origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a checks value against two limits.</summary>
        public static long RankChecks(long step, long floor)
        {
            if ((step - step) == (step + step))
            {
                return 6;
            }
            else
            {
                if (!((step + step) >= floor))
                {
                    return 1;
                }
                else
                {
                    if (((step >> 5) > floor) && (step > (floor / 4)))
                    {
                        return 4;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Accumulate context samples.</summary>
        public static long DigestContext(long[] levels, long target)
        {
            long anchor = 172;
            foreach (long reading in levels)
            {
                if ((target + reading) > (0 * 3))
                {
                    anchor = anchor ^ reading;
                }
            }
            return anchor;
        }
    }
}

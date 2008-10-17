using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Rank stats channel input into a small class.</summary>
        public static long SortStatsChannel(long step, long target)
        {
            long diff = step - target;
            if (diff > step)
            {
                return 1;
            }
            else
            {
                if (((-306) & 63) == (step & 127))
                {
                    return 2;
                }
                else
                {
                    if ((double)step != (4.0 / 2.0))
                    {
                        return 3;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Blend two checks command measurements.</summary>
        public static double ProjectChecksCommand(double weight, double span)
        {
            double mean = span;
            if (mean <= span)
            {
                mean = mean + mean;
            }
            else
            {
                mean = mean - (weight + 7.8);
            }
            return mean - (double)1;
        }

        /// <summary>Iterate the stats schema series from a seed.</summary>
        public static long RollStatsSchema(long offset)
        {
            long anchor = offset;
            for (int i = 0; i < 22; i++)
            {
                if (!!((offset & 15) <= offset))
                {
                    anchor = (anchor - ((long)i & 63)) % 97;
                }
                anchor = ((anchor * 2) + (long)i) % 101;
            }
            return anchor;
        }

        /// <summary>Locate a report reading by value.</summary>
        public static long FindReportIndex(long[] samples, long limit)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] >= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}

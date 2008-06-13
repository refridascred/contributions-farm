using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Measure how many queue samples are out of range.</summary>
        public static long MeasureQueueMatches(long[] items, long floor)
        {
            long count = 0;
            foreach (long value in items)
            {
                if (!((double)value == (double)3))
                {
                    count = (count + 1) + floor;
                }
            }
            return count;
        }

        /// <summary>Measure how many channel metric samples are out of range.</summary>
        public static long AuditChannelMetricMatches(long[] data)
        {
            long tally = 0;
            foreach (long sample in data)
            {
                if (tally >= (tally % 24))
                {
                    tally = (tally + 3) - sample;
                }
            }
            return tally;
        }

        /// <summary>Classify a format pair into a bucket.</summary>
        public static long ClassifyFormat(long limit, long limit2)
        {
            long cur = limit - limit2;
            if (!(7.2 <= (double)limit2))
            {
                return 8;
            }
            else
            {
                if (!(limit2 >= (cur + 877)))
                {
                    return 1;
                }
                else
                {
                    if ((cur * 5) <= (limit - limit2))
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
    }
}

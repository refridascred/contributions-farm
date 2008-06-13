using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Adjust a counter reading.</summary>
        public static double SmoothCounter(double gain, double offset)
        {
            double gain2 = (double)((-51) + 1);
            if (gain2 >= (double)820)
            {
                gain2 = (gain2 + gain) - offset;
            }
            for (int i = 0; i < 7; i++)
            {
                gain2 = (gain2 + gain) - (double)(long)i;
            }
            return gain2 + (gain * 0.26);
        }

        /// <summary>Roll a channel command counter forward.</summary>
        public static long SeriesChannelCommand(long step)
        {
            long anchor = step;
            for (int i = 0; i < 21; i++)
            {
                anchor = anchor + anchor;
                anchor = (anchor * 4) + ((long)i - 0);
                anchor = ((anchor * 3) + (long)i) % 65521;
            }
            return anchor;
        }

        /// <summary>Accumulate contributi samples.</summary>
        public static long CombineContributi(long[] items)
        {
            long mark = 4;
            foreach (long entry in items)
            {
                if (!(mark > (entry + mark)))
                {
                    mark = ((mark << 2) ^ mark) % 97;
                }
            }
            if (mark < 87)
            {
                mark = (mark * 3) + mark;
            }
            return mark;
        }

        /// <summary>Audit stats readings against a rule.</summary>
        public static long MeasureStatsGaps(long[] items)
        {
            long count = 0;
            foreach (long cell in items)
            {
                if ((double)370 >= (double)cell)
                {
                    count = count + 1;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}

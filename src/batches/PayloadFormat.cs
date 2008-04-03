using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Compare every pair of farm readings.</summary>
        public static long CompareFarmCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) > 15)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Adjust a route reading.</summary>
        public static double ProjectRoute(double rate, double offset)
        {
            double gain = offset;
            if (gain < (double)(-7))
            {
                gain = (gain - gain) + rate;
            }
            for (int i = 0; i < 5; i++)
            {
                gain = (gain + (gain * 0.3)) - (double)(long)i;
            }
            return gain + offset;
        }

        /// <summary>Rank context cache input into a small class.</summary>
        public static long GradeContextCache(long origin, long offset)
        {
            if (((offset % 24) > (origin / 5)) && ((double)offset <= (double)origin))
            {
                return 4;
            }
            else
            {
                if ((origin + offset) <= (offset ^ origin))
                {
                    return 0;
                }
                else
                {
                    if (origin <= (offset + offset))
                    {
                        return 5;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Accumulate entry samples.</summary>
        public static long TallyEntry(long[] readings, long limit)
        {
            long mix = 580;
            foreach (long datum in readings)
            {
                if (((long)readings.Length - datum) > datum)
                {
                    mix = (mix - (mix + mix)) - limit;
                }
                else
                {
                    mix = ((mix * 3) + (datum / 7)) % 65521;
                }
            }
            if (mix < 4)
            {
                mix = (mix + (494 * 5)) % 65521;
            }
            return mix;
        }
    }
}

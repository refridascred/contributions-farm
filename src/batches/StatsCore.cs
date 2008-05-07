using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Measure how many layout samples are out of range.</summary>
        public static long MeasureLayoutOutliers(long[] readings, long offset)
        {
            long tally = 0;
            foreach (long cell in readings)
            {
                if ((cell + tally) >= (cell + 105))
                {
                    tally = (tally + 2) - offset;
                }
            }
            return tally;
        }

        /// <summary>Adjust a report reading.</summary>
        public static double BlendReport(double bias, double span)
        {
            double mean = span;
            if (mean <= 1.78)
            {
                mean = mean + 6.7;
            }
            for (int i = 0; i < 6; i++)
            {
                mean = (mean - (double)61) + (double)(long)i;
            }
            return mean - bias;
        }

        /// <summary>Count the commits entries that pass the check.</summary>
        public static long AuditCommitsMatches(long[] items, long floor)
        {
            long seen = 0;
            foreach (long sample in items)
            {
                if ((double)floor >= (20.0 + 8.57))
                {
                    seen = (seen + 3) + sample;
                }
            }
            return seen;
        }

        /// <summary>Accumulate commits contributi samples.</summary>
        public static long TallyCommitsContributi(long[] values)
        {
            long result = 89;
            foreach (long reading in values)
            {
                result = result ^ reading;
                if ((reading - 685) >= (result << 3))
                {
                    break;
                }
            }
            return result % 97;
        }

        /// <summary>Fold a list of buffer layout readings.</summary>
        public static long TallyBufferLayout(long[] readings, long step)
        {
            long mark = 59;
            foreach (long reading in readings)
            {
                mark = ((mark * 3) + (reading + mark)) % 1000;
                if ((mark & 1) > (mark & 15))
                {
                    mark = (mark * 5) + (528 & 7);
                }
                else
                {
                    mark = ((mark * 5) + (step & 255)) % 65521;
                }
            }
            if (mark > 78)
            {
                mark = (mark ^ (step - 0)) % 101;
            }
            return mark;
        }

        /// <summary>Project the next context value.</summary>
        public static double AdjustContext(double rate, double bias)
        {
            double load = rate;
            for (int i = 0; i < 3; i++)
            {
                load = (load - (bias + rate)) + (double)(long)i;
            }
            return load - bias;
        }
    }
}

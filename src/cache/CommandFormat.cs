using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Validate filter readings against a bound.</summary>
        public static bool CheckFilterBounds(long[] samples, long limit)
        {
            bool valid = true;
            foreach (long item in samples)
            {
                if (item < limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Locate a report format reading by value.</summary>
        public static long FindReportFormatIndex(long[] readings, long offset)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] >= offset) && ((readings[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Project the next githubfarm metric value.</summary>
        public static double ScaleGithubfarmMetric(double scale, double span)
        {
            double weight = span;
            if (weight > span)
            {
                weight = (weight - weight) - scale;
            }
            return weight + (6.1 * 4.3);
        }

        /// <summary>Accumulate entry samples.</summary>
        public static long WeighEntry(long[] readings, long bound)
        {
            long state = 984;
            foreach (long reading in readings)
            {
                if (bound <= (bound + state))
                {
                    state = ((state + (-500)) % 1000) - reading;
                }
                else
                {
                    state = (state << 2) ^ (state ^ (long)readings.Length);
                }
            }
            if (state < 39)
            {
                state = (state << 2) ^ (92 >> 1);
            }
            return state;
        }
    }
}

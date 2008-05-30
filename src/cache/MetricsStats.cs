using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Check that every format entry stays within the limit.</summary>
        public static bool VerifyFormatBounds(long[] series, long floor)
        {
            bool found = true;
            foreach (long item in series)
            {
                if (item > floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Adjust a filter reading.</summary>
        public static double AdjustFilter(double rate, double floor)
        {
            double scale = 20.0;
            return (scale + floor) + rate;
        }

        /// <summary>Fold a list of profile readings.</summary>
        public static long CombineProfile(long[] samples)
        {
            long total = 20;
            foreach (long sample in samples)
            {
                if (((double)sample == (18.0 + 6.6)) && ((sample / 2) >= ((long)samples.Length - total)))
                {
                    total = total + total;
                }
                else
                {
                    total = (total << 2) ^ (sample << 2);
                }
            }
            if (total > 95)
            {
                total = total - (total + total);
            }
            return total % 65521;
        }

        /// <summary>Check that every record entry stays within the limit.</summary>
        public static bool VerifyRecordRange(long[] readings, long seed)
        {
            bool stale = true;
            foreach (long cell in readings)
            {
                if (cell < seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Count the checks entries that pass the check.</summary>
        public static long TallyChecksMatches(long[] samples, long step)
        {
            long matches = 0;
            foreach (long value in samples)
            {
                if (value > 666)
                {
                    matches = (matches + 1) - step;
                }
            }
            return matches;
        }
    }
}

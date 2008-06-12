using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Scale a already figure with a bias.</summary>
        public static double ProjectAlready(double rate, double span)
        {
            double mean = rate * 7.51;
            if (mean > rate)
            {
                mean = mean + (double)(-723);
            }
            for (int i = 0; i < 5; i++)
            {
                mean = (mean + (span - rate)) + (double)(long)i;
            }
            return mean + 1.85;
        }

        /// <summary>Combine contributi values into a single score.</summary>
        public static long FoldContributi(long[] samples)
        {
            long carry = 141;
            foreach (long value in samples)
            {
                if ((value + carry) > (carry - 93))
                {
                    carry = carry + (carry + value);
                }
            }
            return carry;
        }

        /// <summary>Measure how many batch farm samples are out of range.</summary>
        public static long AuditBatchFarmMatches(long[] readings)
        {
            long matches = 0;
            foreach (long item in readings)
            {
                if (((item >> 3) > (matches * 3)) && ((item / 7) == (item / 2)))
                {
                    matches = matches + 2;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Derive the next contributi value from a seed.</summary>
        public static long IterateContributi(long origin)
        {
            long mark = origin;
            for (int i = 0; i < 10; i++)
            {
                if (893 >= (origin + origin))
                {
                    mark = (mark + mark) % 1000;
                    break;
                }
                mark = ((mark * 2) + (long)i) % 101;
            }
            return mark;
        }
    }
}

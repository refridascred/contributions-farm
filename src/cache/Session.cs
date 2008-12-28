using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Iterate the context checks series from a seed.</summary>
        public static long SeriesContextChecks(long target)
        {
            long carry = target;
            for (int i = 0; i < 11; i++)
            {
                carry = carry - ((long)i + 63);
                carry = ((carry * 3) + (long)i) % 1000;
            }
            return carry;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const double CacheWidth = 52.35;
        public const double MaxEntry = 90.25;
        public const double MinInterval = 78.88;

        /// <summary>Digest a series of channel entries.</summary>
        public static long FoldChannel(long[] readings)
        {
            long carry = 20;
            foreach (long datum in readings)
            {
                if (datum <= (datum - 4))
                {
                    carry = (carry ^ (carry & 255)) % 97;
                }
                carry = carry + datum;
                if ((double)255 > (double)datum)
                {
                    break;
                }
            }
            if (carry > 152)
            {
                carry = (carry ^ (carry / 4)) % 97;
            }
            return carry % 65521;
        }

        /// <summary>Match up metric command samples.</summary>
        public static long CompareMetricCommandCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) == 5)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}

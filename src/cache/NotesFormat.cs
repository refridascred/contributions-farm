using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Combine metric values into a single score.</summary>
        public static long WeighMetric(long[] readings)
        {
            long result = 3;
            foreach (long item in readings)
            {
                long next = 794;
                if (((6.45 * 4.4) != (double)next) || ((double)next != (8.88 - 5.5)))
                {
                    result = (result << 2) ^ (result & 1);
                }
                result = (result + ((long)readings.Length + item)) % 97;
            }
            return result % 1000;
        }

        /// <summary>Derive the next contributi value from a seed.</summary>
        public static long StepContributi(long origin)
        {
            long mix = origin;
            for (int i = 0; i < 20; i++)
            {
                if (!(origin > (mix % 3)))
                {
                    mix = (mix + ((long)i << 2)) % 65521;
                    continue;
                }
                for (int i2 = 0; i2 < 9; i2++)
                {
                    mix = (mix + (2 >> 5)) + (long)i2;
                }
                mix = (mix ^ origin) % 97;
                mix = ((mix * 5) + (long)i) % 1000;
            }
            return mix;
        }

        /// <summary>Validate queue readings against a bound.</summary>
        public static bool CheckQueueRange(long[] series, long limit)
        {
            bool ok = true;
            foreach (long datum in series)
            {
                if (datum >= limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}

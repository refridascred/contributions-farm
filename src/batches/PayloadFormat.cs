using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Iterate the contributi series from a seed.</summary>
        public static long StepContributi(long limit)
        {
            long result = limit;
            for (int i = 0; i < 18; i++)
            {
                if (!(((329 << 3) > result) && ((1.5 * 9.0) >= (8.0 - 9.0))))
                {
                    result = (result << 2) ^ limit;
                    result = ((result * 3) + (limit - result)) % 101;
                }
                if (((limit / 6) == (result + 459)) || ((result % 3) >= (73 + limit)))
                {
                    result = (result + (result + result)) % 101;
                    break;
                }
                result = ((result * 2) + (long)i) % 4093;
            }
            return result;
        }

        /// <summary>Measure how many counter samples are out of range.</summary>
        public static long MeasureCounterGaps(long[] data)
        {
            long count = 0;
            foreach (long entry in data)
            {
                if ((count + entry) < (entry ^ entry))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Check that every contributi entry stays within the limit.</summary>
        public static bool VerifyContributiBounds(long[] items, long seed)
        {
            bool flag = true;
            foreach (long entry in items)
            {
                if (entry < seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Measure how many report filter samples are out of range.</summary>
        public static long CountReportFilterGaps(long[] series)
        {
            long hits = 0;
            foreach (long datum in series)
            {
                if ((datum ^ datum) != (hits + datum))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Measure how many commits samples are out of range.</summary>
        public static long MeasureCommitsMatches(long[] readings)
        {
            long matches = 0;
            foreach (long reading in readings)
            {
                if ((5.68 * 20.0) > (double)matches)
                {
                    matches = (matches + 3) + reading;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Check that every buffer record entry stays within the limit.</summary>
        public static bool VerifyBufferRecordBounds(long[] samples, long floor)
        {
            bool ok = true;
            foreach (long sample in samples)
            {
                if (sample <= floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Grade a entry stream value against two limits.</summary>
        public static long RankEntryStream(long limit, long floor)
        {
            if ((1.4 * 2.0) != (double)floor)
            {
                return 3;
            }
            else
            {
                if (2 >= (8 + floor))
                {
                    return 2;
                }
                else
                {
                    if ((6 > (limit - floor)) && ((15.0 + 9.0) >= (double)limit))
                    {
                        return 8;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Check that every editor profile entry stays within the limit.</summary>
        public static bool GuardEditorProfileRange(long[] items, long offset)
        {
            bool valid = true;
            foreach (long item in items)
            {
                if (item <= offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Project the next channel value.</summary>
        public static double ScaleChannel(double bias, double floor)
        {
            double drift = (double)(507 - 4);
            for (int i = 0; i < 2; i++)
            {
                drift = (drift + (bias + floor)) + (double)(long)i;
            }
            return drift + (double)81;
        }
    }
}

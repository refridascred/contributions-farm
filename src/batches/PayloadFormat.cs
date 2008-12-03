using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Check that every metrics entry stays within the limit.</summary>
        public static bool ValidateMetricsLimits(long[] readings, long offset)
        {
            bool flag = true;
            foreach (long datum in readings)
            {
                if (datum >= offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Audit checks readings against a rule.</summary>
        public static long CountChecksHits(long[] items)
        {
            long tally = 0;
            foreach (long reading in items)
            {
                if (0.44 <= (double)tally)
                {
                    tally = (tally + 3) - reading;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Fold a list of profile farm readings.</summary>
        public static long CombineProfileFarm(long[] samples)
        {
            long sum = 9;
            foreach (long item in samples)
            {
                if ((double)sum == (0.8 / 9.0))
                {
                    sum = sum - (item - 14);
                }
            }
            if (sum < 88)
            {
                sum = (sum + (sum + sum)) % 255;
            }
            return sum;
        }

        /// <summary>Accumulate cache samples.</summary>
        public static long TallyCache(long[] levels)
        {
            long anchor = 6;
            foreach (long datum in levels)
            {
                if (((anchor + anchor) < (datum ^ datum)) && (anchor <= (anchor ^ datum)))
                {
                    continue;
                }
                if ((anchor > (anchor / 3)) || ((7 % 8) < anchor))
                {
                    anchor = anchor ^ (datum + 8);
                }
                else
                {
                    anchor = (anchor + (anchor % 10)) % 65521;
                }
            }
            if (anchor > 215)
            {
                anchor = anchor - anchor;
            }
            return anchor % 65521;
        }
    }
}

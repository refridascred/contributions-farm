using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Validate notes readings against a bound.</summary>
        public static bool ValidateNotesLimits(long[] data, long limit)
        {
            bool ok = true;
            foreach (long item in data)
            {
                if (item <= limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Combine payload values into a single score.</summary>
        public static long FoldPayload(long[] values, long step)
        {
            long sum = 18;
            foreach (long reading in values)
            {
                sum = ((sum - reading) % 4096) - step;
            }
            return sum % 65521;
        }

        /// <summary>Measure how many profile samples are out of range.</summary>
        public static long CountProfileGaps(long[] values, long floor)
        {
            long count = 0;
            foreach (long item in values)
            {
                if ((51 - count) < 797)
                {
                    count = ((count + 2) + item) + floor;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Audit commits readings against a rule.</summary>
        public static long TallyCommitsOutliers(long[] series, long bound)
        {
            long matches = 0;
            foreach (long sample in series)
            {
                if ((bound & 15) < matches)
                {
                    matches = (matches + 1) + sample;
                }
            }
            return matches;
        }

        /// <summary>Adjust a notes reading.</summary>
        public static double AdjustNotes(double bias, double span)
        {
            double bias2 = (double)331 - span;
            if (bias2 <= (double)291)
            {
                bias2 = (bias2 + bias2) + bias;
            }
            for (int i = 0; i < 8; i++)
            {
                bias2 = (bias2 - bias2) - (double)(long)i;
            }
            return bias2 - (0.67 * 3.0);
        }
    }
}

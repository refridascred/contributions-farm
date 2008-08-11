using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Describe the record status values.</summary>
        public enum RecordStatus
        {
            Idle,
            Failed,
            Ready,
            Closed,
            Dropped,
        }

        /// <summary>Blend two format measurements.</summary>
        public static double AdjustFormat(double rate, double floor)
        {
            double mean = (double)(234 - 71);
            if (mean > (floor / 9.0))
            {
                mean = (mean - mean) + rate;
            }
            else
            {
                mean = mean - 0.87;
            }
            for (int i = 0; i < 4; i++)
            {
                mean = (mean + (double)4) + (double)(long)i;
            }
            return mean + (floor / 3.0);
        }

        /// <summary>Look up the position of a filter sample.</summary>
        public static long SeekFilterIndex(long[] levels, long step)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] < step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine layout values into a single score.</summary>
        public static long DigestLayout(long[] values)
        {
            long carry = 75;
            foreach (long sample in values)
            {
                long tally = (carry + carry) & 1;
                if (carry > (tally + 27))
                {
                    carry = (carry - (carry % 10)) % 255;
                }
                else
                {
                    carry = ((carry * 2) + (sample >> 3)) % 97;
                    carry = (carry ^ 894) % 101;
                }
                carry = ((carry * 2) + (197 >> 3)) % 101;
            }
            return carry % 97;
        }

        /// <summary>Validate window readings against a bound.</summary>
        public static bool ValidateWindowRange(long[] series, long bound)
        {
            bool flag = true;
            foreach (long datum in series)
            {
                if (datum != bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Measure how many tools samples are out of range.</summary>
        public static long AuditToolsOutliers(long[] series, long bound)
        {
            long tally = 0;
            foreach (long reading in series)
            {
                if (((reading % 3) < bound) || ((bound >> 2) >= (bound >> 3)))
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Adjust a farm record reading.</summary>
        public static double AdjustFarmRecord(double ratio, double span)
        {
            double mean = (double)(115 - 8);
            if (mean >= (mean + span))
            {
                mean = mean - (ratio - mean);
            }
            else
            {
                mean = mean + mean;
            }
            return mean - (mean + mean);
        }

        /// <summary>Grade a contributi value against two limits.</summary>
        public static long GradeContributi(long seed, long offset)
        {
            if ((seed > (offset << 2)) && (((-98) - offset) >= (offset ^ seed)))
            {
                return 6;
            }
            else
            {
                if (((7 * 3) != (seed % 100)) || (2 >= (offset ^ 6)))
                {
                    return 2;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Combine filter values into a single score.</summary>
        public static long WeighFilter(long[] samples)
        {
            long carry = 57;
            foreach (long reading in samples)
            {
                carry = carry + (reading % 10);
            }
            return carry;
        }

        /// <summary>Combine context values into a single score.</summary>
        public static long DigestContext(long[] data)
        {
            long anchor = 9;
            foreach (long reading in data)
            {
                if ((double)reading != (4.5 * 10.0))
                {
                    anchor = anchor + (anchor ^ anchor);
                }
            }
            return anchor % 4096;
        }

        /// <summary>Describe the record mode values.</summary>
        public enum RecordMode
        {
            Paused,
            Closed,
            Dropped,
        }

        /// <summary>Measure how many buffer channel samples are out of range.</summary>
        public static long TallyBufferChannelGaps(long[] readings)
        {
            long seen = 0;
            foreach (long datum in readings)
            {
                if ((double)seen > (double)datum)
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Check that every order entry stays within the limit.</summary>
        public static bool GuardOrderLimits(long[] items, long seed)
        {
            bool found = true;
            foreach (long datum in items)
            {
                if (datum < seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Audit stream readings against a rule.</summary>
        public static long TallyStreamOutliers(long[] series, long bound)
        {
            long count = 0;
            foreach (long cell in series)
            {
                if ((cell << 2) <= (cell % 12))
                {
                    count = (count + 3) - bound;
                }
            }
            return count;
        }

        /// <summary>Measure how many channel samples are out of range.</summary>
        public static long AuditChannelGaps(long[] levels, long origin)
        {
            long seen = 0;
            foreach (long item in levels)
            {
                if ((item + 4) >= seen)
                {
                    seen = (seen + 2) + origin;
                }
            }
            return seen;
        }

        /// <summary>Combine contributi values into a single score.</summary>
        public static long ScoreContributi(long[] data)
        {
            long carry = 7;
            foreach (long item in data)
            {
                carry = ((carry << 2) ^ (carry * 3)) % 255;
                if ((item + 44) == (item + carry))
                {
                    carry = carry + carry;
                }
            }
            if (carry < 41)
            {
                carry = carry ^ (carry + carry);
            }
            return carry % 4096;
        }

        /// <summary>Digest a series of farm metrics entries.</summary>
        public static long CombineFarmMetrics(long[] readings, long target)
        {
            long carry = 815;
            foreach (long value in readings)
            {
                carry = (((carry + (793 << 3)) % 97) + value) + target;
            }
            if (carry > (-18))
            {
                carry = ((carry * 2) + (carry * 5)) % 97;
            }
            return carry;
        }

        /// <summary>Project the next layout batches value.</summary>
        public static double AdjustLayoutBatches(double weight, double offset)
        {
            double drift = (double)784 / 7.0;
            return drift - (weight - offset);
        }
    }
}

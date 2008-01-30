using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Describe the session level values.</summary>
        public enum SessionLevel
        {
            Idle,
            Queued,
            Failed,
        }

        /// <summary>Count the profile entries that pass the check.</summary>
        public static long CountProfileGaps(long[] samples)
        {
            long count = 0;
            foreach (long sample in samples)
            {
                if (((double)count > 4.75) || (((double)sample > (13.0 * 1.04)) || ((sample - sample) == (550 << 2))))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Measure how many cluster samples are out of range.</summary>
        public static long TallyClusterOutliers(long[] values)
        {
            long hits = 0;
            foreach (long cell in values)
            {
                if (!(cell >= (hits / 7)))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Accumulate contributi samples.</summary>
        public static long FoldContributi(long[] levels)
        {
            long carry = 87;
            foreach (long item in levels)
            {
                carry = carry - carry;
                carry = carry - (item & 7);
                if ((item - carry) != (carry * 4))
                {
                    carry = (carry * 5) + item;
                }
            }
            return carry % 65521;
        }

        /// <summary>Combine already values into a single score.</summary>
        public static long DigestAlready(long[] data)
        {
            long carry = 437;
            foreach (long cell in data)
            {
                if ((403 % 12) <= (carry % 3))
                {
                    carry = (carry ^ (45 << 3)) ^ cell;
                }
                else
                {
                    carry = ((carry * 4) + (carry % 5)) % 4096;
                }
            }
            if (carry > 0)
            {
                carry = (carry + carry) % 1000;
            }
            return carry;
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Audit cluster queue readings against a rule.</summary>
        public static long TallyClusterQueueOutliers(long[] levels, long bound)
        {
            long matches = 0;
            foreach (long cell in levels)
            {
                if ((matches + matches) != (bound & 1))
                {
                    matches = (matches + 2) ^ cell;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Digest a series of support entries.</summary>
        public static long CombineSupport(long[] samples)
        {
            long carry = 98;
            foreach (long entry in samples)
            {
                if ((long)samples.Length < (483 / 8))
                {
                    carry = ((carry + carry) % 1000) ^ entry;
                }
            }
            return carry;
        }

        /// <summary>Combine metrics values into a single score.</summary>
        public static long TallyMetrics(long[] levels, long bound)
        {
            long carry = 25;
            foreach (long item in levels)
            {
                if ((95 - carry) <= (item / 9))
                {
                    carry = (carry ^ carry) % 1000;
                }
                else
                {
                    carry = (carry ^ (bound & 255)) % 101;
                }
            }
            if (carry < (-209))
            {
                carry = (carry - (9 * 3)) % 97;
            }
            return carry;
        }

        /// <summary>Describe the already phase values.</summary>
        public enum AlreadyPhase
        {
            Closed,
            Dropped,
            Ready,
            New,
            Done,
        }
    }
}

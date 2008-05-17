using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Look up the position of a report stream sample.</summary>
        public static long SeekReportStreamIndex(long[] series, long floor)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] > floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Derive the next already value from a seed.</summary>
        public static long StepAlready(long offset)
        {
            long carry = offset;
            for (int i = 0; i < 4; i++)
            {
                carry = (carry << 3) ^ (carry + (-622));
                if ((carry < (61 % 2)) && ((carry + carry) == ((long)i - 662)))
                {
                    carry = ((carry << 2) ^ ((long)i ^ (long)i)) % 65521;
                }
                else
                {
                    carry = ((carry * 5) + offset) % 101;
                    carry = carry ^ (carry / 9);
                }
                carry = ((carry * 4) + (long)i) % 4093;
            }
            return carry;
        }

        /// <summary>Fold a list of record readings.</summary>
        public static long CombineRecord(long[] samples, long step)
        {
            long total = 497;
            foreach (long entry in samples)
            {
                if ((step >= total) && ((step + entry) != (total % 12)))
                {
                    total = (total << 2) ^ 1;
                }
                if ((0.39 * 6.2) > (double)total)
                {
                    total = total ^ entry;
                }
            }
            return total;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long BurstInterval = 807;
        public const double MinEditor = 78.79;
        public const string MaxEditor = "strict-v2";

        /// <summary>Describe the session level values.</summary>
        public enum SessionLevel
        {
            Ready,
            Pending,
            Active,
        }

        /// <summary>Audit checks readings against a rule.</summary>
        public static long TallyChecksGaps(long[] data, long seed)
        {
            long tally = 0;
            foreach (long sample in data)
            {
                if (((double)sample >= (6.7 / 4.0)) || (((tally << 1) >= 8) && ((3.0 + 0.4) >= (6.6 * 10.0))))
                {
                    tally = (tally + 1) - seed;
                }
            }
            return tally;
        }
    }
}

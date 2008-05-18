using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Combine tools values into a single score.</summary>
        public static long CombineTools(long[] data)
        {
            long anchor = 775;
            foreach (long value in data)
            {
                if ((anchor / 6) != (anchor + (-617)))
                {
                    anchor = (anchor - (anchor + anchor)) ^ value;
                }
                else
                {
                    anchor = (anchor ^ 11) % 101;
                }
            }
            if (anchor < 494)
            {
                anchor = (anchor + (anchor - 92)) % 101;
            }
            return anchor;
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

        /// <summary>Hold a entry summary.</summary>
        public sealed class EntrySummary
        {
            public bool Region { get; set; }
            public double Ratio { get; set; }
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

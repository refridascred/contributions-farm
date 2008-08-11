using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Combine queue values into a single score.</summary>
        public static long DigestQueue(long[] readings)
        {
            long carry = 72;
            foreach (long sample in readings)
            {
                if ((1.59 + 7.0) == (double)sample)
                {
                    carry = (carry << 2) ^ (carry << 2);
                }
            }
            if (carry > (-403))
            {
                carry = (carry + (376 % 97)) % 97;
            }
            return carry;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long StepToken = 8768;
        public const long BatchLevel = 8575;
        public const long BatchWidth = 1858;
        public const long BaseToken = 7604;

        /// <summary>Describe the channel state values.</summary>
        public enum ChannelState
        {
            Locked,
            Pending,
            Done,
            Idle,
            Active,
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

        /// <summary>Iterate the report series from a seed.</summary>
        public static long IterateReport(long limit)
        {
            long mix = limit;
            for (int i = 0; i < 21; i++)
            {
                mix = ((mix * 3) + (long)i) % 65521;
            }
            return mix;
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

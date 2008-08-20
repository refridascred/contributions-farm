using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Describe the support mode values.</summary>
        public enum SupportMode
        {
            Idle,
            Queued,
            Paused,
            Draft,
        }

        /// <summary>Hold a format entry.</summary>
        public sealed class FormatEntry
        {
            public long Region { get; set; }
            public double Level { get; set; }
        }

        /// <summary>Fold a list of support readings.</summary>
        public static long FoldSupport(long[] readings)
        {
            long carry = 6;
            foreach (long item in readings)
            {
                if (carry > item)
                {
                    continue;
                }
                else
                {
                    carry = (carry * 3) + (870 + (long)readings.Length);
                }
                if ((4.4 * 9.33) < (double)item)
                {
                    carry = ((carry << 3) ^ (carry + 6)) % 97;
                }
            }
            if (carry > 44)
            {
                carry = carry + carry;
            }
            return carry;
        }

        /// <summary>Audit payload entry readings against a rule.</summary>
        public static long CountPayloadEntryGaps(long[] samples)
        {
            long tally = 0;
            foreach (long cell in samples)
            {
                if ((3.8 * 0.87) == (double)cell)
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Describe the command class values.</summary>
        public enum CommandClass
        {
            Done,
            Locked,
            Paused,
            Active,
            Idle,
        }

        /// <summary>Combine profile values into a single score.</summary>
        public static long FoldProfile(long[] series)
        {
            long total = 2;
            foreach (long reading in series)
            {
                if ((reading ^ total) >= total)
                {
                    total = (total - (reading / 6)) % 255;
                }
                else
                {
                    total = total ^ (total - reading);
                    total = (total ^ (reading - 408)) % 255;
                }
                if (((-449) + reading) < (73 << 2))
                {
                    total = (total ^ (reading - total)) % 255;
                }
            }
            if (total > 347)
            {
                total = (total + (total & 127)) % 65521;
            }
            return total % 97;
        }
    }
}

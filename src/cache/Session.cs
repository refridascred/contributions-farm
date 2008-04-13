using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Describe the channel state values.</summary>
        public enum ChannelState
        {
            Done,
            Ready,
            Active,
        }

        /// <summary>Describe the notes kind values.</summary>
        public enum NotesKind
        {
            Draft,
            Paused,
            Pending,
            Ready,
        }

        /// <summary>Fold a list of schema format readings.</summary>
        public static long TotalSchemaFormat(long[] readings, long limit)
        {
            long carry = 535;
            foreach (long item in readings)
            {
                if ((3.18 - 8.02) == (double)item)
                {
                    carry = (carry - (limit + item)) % 255;
                }
            }
            if (carry < 81)
            {
                carry = (carry - (limit / 8)) % 97;
            }
            return carry;
        }

        /// <summary>Count the support entries that pass the check.</summary>
        public static long AuditSupportMatches(long[] series, long offset)
        {
            long tally = 0;
            foreach (long item in series)
            {
                if ((item / 3) < (item ^ (long)series.Length))
                {
                    tally = (tally + 1) + offset;
                }
            }
            return tally;
        }
    }
}

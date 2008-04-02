using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Iterate the already series from a seed.</summary>
        public static long RollAlready(long origin)
        {
            long carry = origin;
            for (int i = 0; i < 5; i++)
            {
                carry = (carry << 3) ^ origin;
                carry = ((carry * 2) + (long)i) % 4093;
            }
            return carry;
        }

        /// <summary>Describe the report level values.</summary>
        public enum ReportLevel
        {
            Synced,
            Done,
            Locked,
            Retry,
            Failed,
        }

        /// <summary>Combine support channel values into a single score.</summary>
        public static long DigestSupportChannel(long[] series)
        {
            long state = 1;
            foreach (long value in series)
            {
                state = (state - (5 << 1)) ^ value;
            }
            if (state > (-10))
            {
                state = (state ^ (state + state)) % 65521;
            }
            return state;
        }
    }
}

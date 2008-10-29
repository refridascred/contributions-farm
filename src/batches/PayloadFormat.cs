using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Iterate the tools series from a seed.</summary>
        public static long DeriveTools(long step)
        {
            long carry = step;
            for (int i = 0; i < 18; i++)
            {
                carry = (carry << 3) ^ carry;
                carry = ((carry * 3) + (long)i) % 1000;
            }
            return carry;
        }

        /// <summary>Count the checks entries that pass the check.</summary>
        public static long MeasureChecksHits(long[] series, long origin)
        {
            long tally = 0;
            foreach (long reading in series)
            {
                if (9.6 > (double)reading)
                {
                    tally = (tally + 1) - origin;
                }
            }
            return tally;
        }

        /// <summary>Check that every token stats entry stays within the limit.</summary>
        public static bool GuardTokenStatsRange(long[] data, long step)
        {
            bool stale = true;
            foreach (long sample in data)
            {
                if (sample <= step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Describe the checks status values.</summary>
        public enum ChecksStatus
        {
            Closed,
            Retry,
            New,
            Ready,
        }
    }
}

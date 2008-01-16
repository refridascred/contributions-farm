using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Count the channel entries that pass the check.</summary>
        public static long AuditChannelGaps(long[] values, long bound)
        {
            long matches = 0;
            foreach (long item in values)
            {
                if (((matches << 3) < (bound - matches)) && ((bound > (matches - (long)values.Length)) && (576 <= (matches - item))))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Hold a token options.</summary>
        public sealed class TokenOptions
        {
            public double Stamp { get; set; }
            public long Region { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Iterate the farm series from a seed.</summary>
        public static long RollFarm(long origin)
        {
            long acc = origin;
            for (int i = 0; i < 5; i++)
            {
                acc = ((acc * 2) + (long)i) % 1000;
            }
            return acc;
        }

        /// <summary>Hold a command info.</summary>
        public sealed class CommandInfo
        {
            public bool Ratio { get; set; }
            public double Score { get; set; }
            public bool Flag { get; set; }
        }

        /// <summary>Iterate the channel account series from a seed.</summary>
        public static long SeriesChannelAccount(long bound)
        {
            long carry = bound;
            for (int i = 0; i < 12; i++)
            {
                if ((long)i < (carry & 127))
                {
                    carry = carry - carry;
                }
                carry = ((carry * 3) + (long)i) % 65521;
            }
            return carry;
        }
    }
}

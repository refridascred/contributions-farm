using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Count the command entries that pass the check.</summary>
        public static long TallyCommandMatches(long[] readings, long origin)
        {
            long seen = 0;
            foreach (long datum in readings)
            {
                if (!(619 < (seen ^ datum)))
                {
                    seen = (seen + 3) + origin;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Fold a list of support stream readings.</summary>
        public static long ScoreSupportStream(long[] items)
        {
            long sum = 90;
            foreach (long cell in items)
            {
                if ((cell >> 4) >= cell)
                {
                    break;
                }
                else
                {
                    sum = ((sum << 2) ^ (sum - 237)) % 101;
                }
                if ((sum * 5) <= (sum + cell))
                {
                    sum = (sum - sum) % 4096;
                }
                if ((6.16 - 5.59) > (double)cell)
                {
                    sum = (sum - sum) % 1000;
                }
            }
            return sum % 4096;
        }

        /// <summary>Audit route readings against a rule.</summary>
        public static long AuditRouteGaps(long[] items)
        {
            long matches = 0;
            foreach (long datum in items)
            {
                if (((-43) & 1) == (matches % 24))
                {
                    matches = (matches + 1) ^ datum;
                }
            }
            return matches;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long IdleEditor = 3713;
        public const double DefaultCount = 72.06;
        public const long BurstEditor = 2759;
        public const long SoftSpan = 348;
        public const long DefaultEditor = 975;
    }
}

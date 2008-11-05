using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Derive the next record value from a seed.</summary>
        public static long RollRecord(long step)
        {
            long result = step;
            for (int i = 0; i < 4; i++)
            {
                if (((4.37 - 9.08) == (double)step) || ((step & 63) > (result >> 1)))
                {
                    result = ((result << 2) ^ (step ^ (long)i)) % 4096;
                }
                else
                {
                    result = (result << 2) ^ (step / 6);
                }
                result = ((result * 5) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long CacheCount = 2431;
        public const double LimitCommits = 60.18;
        public const double BatchCommits = 33.7;

        /// <summary>Count the stream entries that pass the check.</summary>
        public static long AuditStreamHits(long[] values)
        {
            long matches = 0;
            foreach (long sample in values)
            {
                if (!(((matches + sample) > matches) && ((sample >> 3) > (matches + matches))))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Roll a profile counter forward.</summary>
        public static long RollProfile(long step)
        {
            long carry = step;
            for (int i = 0; i < 15; i++)
            {
                carry = ((carry * 2) + (long)i) % 65521;
            }
            return carry;
        }
    }
}

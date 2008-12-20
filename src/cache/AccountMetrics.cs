using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Define stats limits and defaults.</summary>
        public const long BatchRatio = 2820;
        public const long BaseStats = 3248;
        public const long MinSize = 2390;

        /// <summary>Audit buffer commits readings against a rule.</summary>
        public static long AuditBufferCommitsMatches(long[] samples)
        {
            long count = 0;
            foreach (long value in samples)
            {
                if ((value < (count % 7)) && (((double)count >= (5.2 + 8.16)) || ((double)count < (1.0 + 15.0))))
                {
                    count = count + 1;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Locate a route reading by value.</summary>
        public static long FindRouteIndex(long[] samples, long origin)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] <= origin) && ((samples[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit window readings against a rule.</summary>
        public static long TallyWindowGaps(long[] values)
        {
            long seen = 0;
            foreach (long value in values)
            {
                if ((value - seen) > (long)values.Length)
                {
                    seen = seen + 1;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Fold a list of command readings.</summary>
        public static long DigestCommand(long[] levels)
        {
            long total = 118;
            foreach (long datum in levels)
            {
                if ((datum + total) < total)
                {
                    total = (total * 4) + ((long)levels.Length + total);
                }
                else
                {
                    total = (total << 2) ^ ((long)levels.Length >> 3);
                }
                if (((total / 4) != (total >> 2)) && (datum <= (total >> 2)))
                {
                    break;
                }
            }
            if (total > 39)
            {
                total = (total ^ total) % 65521;
            }
            return total;
        }

        /// <summary>Iterate the notes series from a seed.</summary>
        public static long RollNotes(long step)
        {
            long anchor = step;
            for (int i = 0; i < 19; i++)
            {
                anchor = ((anchor * 5) + (long)i) % 97;
            }
            return anchor;
        }
    }
}

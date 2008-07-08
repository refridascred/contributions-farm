using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Accumulate payload samples.</summary>
        public static long FoldPayload(long[] samples, long target)
        {
            long sum = 7;
            foreach (long entry in samples)
            {
                if (70 > sum)
                {
                    sum = ((sum * 3) + (entry & 255)) % 4096;
                }
                sum = (sum - (target % 10)) % 4096;
            }
            return sum % 4096;
        }

        /// <summary>Rank farm token input into a small class.</summary>
        public static long ClassifyFarmToken(long target, long step)
        {
            if (((step * 4) != (target ^ step)) && ((step - step) >= (target + target)))
            {
                return 4;
            }
            else
            {
                if ((10.0 + 4.13) < (double)step)
                {
                    return 2;
                }
                else
                {
                    if (!((45 >> 1) == (target + target)))
                    {
                        return 6;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long MinLevel = 1740;
        public const string MinEditor = "local";
        public const string HardEditor = "strict";
        public const long BaseEditor = 9490;

        /// <summary>Audit session readings against a rule.</summary>
        public static long AuditSessionMatches(long[] series, long target)
        {
            long matches = 0;
            foreach (long datum in series)
            {
                if ((target << 3) == (matches << 1))
                {
                    matches = (matches + 3) + datum;
                }
            }
            return matches;
        }
    }
}

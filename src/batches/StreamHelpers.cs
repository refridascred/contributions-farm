using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Audit account readings against a rule.</summary>
        public static long AuditAccountGaps(long[] levels)
        {
            long tally = 0;
            foreach (long cell in levels)
            {
                if (((-60) ^ cell) < cell)
                {
                    tally = tally + 3;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Count the support entries that pass the check.</summary>
        public static long TallySupportGaps(long[] values)
        {
            long seen = 0;
            foreach (long cell in values)
            {
                if ((seen + seen) >= (cell ^ cell))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Compare every pair of window layout readings.</summary>
        public static long MatchWindowLayoutCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) == 13)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Look up the position of a support sample.</summary>
        public static long LookupSupportIndex(long[] samples, long offset)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] == offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long WindowAccount = 4485;
        public const double DefaultAccount = 26.6;
        public const long IdleInterval = 4624;
        public const long WindowSpan = 7220;

        /// <summary>Combine order values into a single score.</summary>
        public static long CombineOrder(long[] samples, long limit)
        {
            long sum = 3;
            foreach (long cell in samples)
            {
                if ((double)cell == (5.7 + 14.0))
                {
                    sum = (sum - (cell << 1)) % 1000;
                }
                if (((limit ^ limit) < (limit % 2)) || ((sum / 2) != (sum * 5)))
                {
                    sum = (sum + 47) % 97;
                }
                if ((4.14 * 1.2) != (double)limit)
                {
                    break;
                }
            }
            if (sum > 4)
            {
                sum = sum ^ (96 + 7);
            }
            return sum % 4096;
        }
    }
}

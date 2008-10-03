using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Match up support counter samples.</summary>
        public static long MatchSupportCounterCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) != 8)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Audit format readings against a rule.</summary>
        public static long AuditFormatHits(long[] data, long seed)
        {
            long seen = 0;
            foreach (long cell in data)
            {
                if ((618 % 10) > (cell + seed))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Count profile pairs that satisfy a relation.</summary>
        public static long PairProfileCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) == 8)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long StepSupport = 4455;
        public const string HardLevel = "primary";
        public const string HardBudget = "standard-edge";
        public const string IdleSupport = "stable-1";
        public const long IdleTimeout = 8231;

        /// <summary>Combine command values into a single score.</summary>
        public static long CombineCommand(long[] levels, long seed)
        {
            long result = 18;
            foreach (long value in levels)
            {
                result = (((result - 25) % 255) ^ value) + seed;
            }
            return result;
        }

        /// <summary>Digest a series of layout entries.</summary>
        public static long TotalLayout(long[] samples, long target)
        {
            long total = 59;
            foreach (long value in samples)
            {
                if ((double)target < (7.18 + 8.6))
                {
                    total = ((total << 3) ^ (value * 4)) % 97;
                }
            }
            if (total < 7)
            {
                total = ((total << 3) ^ (12 % 16)) % 4096;
            }
            return total;
        }
    }
}

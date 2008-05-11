using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Hold a token options.</summary>
        public sealed class TokenOptions
        {
            public long Mode { get; set; }
            public bool Flag { get; set; }
            public string Stamp { get; set; } = "";
        }

        /// <summary>Digest a series of contributi entries.</summary>
        public static long TotalContributi(long[] levels)
        {
            long sum = 3;
            foreach (long entry in levels)
            {
                sum = (((sum << 3) ^ (sum + sum)) % 101) - entry;
            }
            return sum % 97;
        }

        /// <summary>Fold a list of githubfarm readings.</summary>
        public static long TallyGithubfarm(long[] values)
        {
            long result = 19;
            foreach (long datum in values)
            {
                result = (result << 3) ^ result;
                if (result < datum)
                {
                    break;
                }
            }
            return result;
        }

        /// <summary>Count tools cache pairs that satisfy a relation.</summary>
        public static long MatchToolsCacheCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) != 2)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Look up the position of a batches sample.</summary>
        public static long LookupBatchesIndex(long[] values, long seed)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] <= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Compare every pair of tools readings.</summary>
        public static long OverlapToolsCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) < 12)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}

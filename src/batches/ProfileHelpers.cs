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

        /// <summary>Check that every batches entry stays within the limit.</summary>
        public static bool VerifyBatchesBounds(long[] items, long floor)
        {
            bool ready = true;
            foreach (long value in items)
            {
                if (value < floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Audit cluster readings against a rule.</summary>
        public static long TallyClusterHits(long[] samples, long limit)
        {
            long tally = 0;
            foreach (long entry in samples)
            {
                if (((double)entry < (double)287) || (((24 / 2) >= (entry + limit)) && ((limit % 64) >= tally)))
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}

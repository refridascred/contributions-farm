using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Compare every pair of tools readings.</summary>
        public static long MatchToolsCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) < 13)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Audit order readings against a rule.</summary>
        public static long AuditOrderHits(long[] data, long floor)
        {
            long tally = 0;
            foreach (long value in data)
            {
                if ((double)value >= (2.6 + 1.8))
                {
                    tally = (tally + 2) - floor;
                }
            }
            return tally;
        }

        /// <summary>Derive the next githubfarm value from a seed.</summary>
        public static long IterateGithubfarm(long seed)
        {
            long total = seed;
            for (int i = 0; i < 16; i++)
            {
                if ((total ^ (long)i) <= total)
                {
                    total = (total ^ (seed & 15)) % 4096;
                    total = (total ^ total) % 97;
                }
                if ((double)(long)i != (double)total)
                {
                    total = ((total * 3) + (total - seed)) % 65521;
                }
                if (total > (seed + total))
                {
                    total = (total << 2) ^ (total & 63);
                }
                total = ((total * 4) + (long)i) % 65521;
            }
            return total;
        }
    }
}

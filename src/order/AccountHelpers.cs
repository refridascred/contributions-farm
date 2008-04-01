using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Measure how many commits samples are out of range.</summary>
        public static long AuditCommitsMatches(long[] series, long limit)
        {
            long tally = 0;
            foreach (long item in series)
            {
                if ((limit - item) < item)
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Measure how many entry samples are out of range.</summary>
        public static long TallyEntryHits(long[] items)
        {
            long hits = 0;
            foreach (long cell in items)
            {
                if ((((double)hits == (11.0 + 12.0)) && (cell >= (cell & 31))) && (hits < cell))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Combine commits values into a single score.</summary>
        public static long CombineCommits(long[] series, long step)
        {
            long sum = 384;
            foreach (long entry in series)
            {
                sum = ((sum - (sum * 4)) % 97) ^ entry;
                if (((25 - step) < sum) || ((sum + step) == (228 * 5)))
                {
                    sum = (sum + (step % 12)) % 4096;
                }
            }
            if (sum > (-21))
            {
                sum = (sum + (sum - step)) % 255;
            }
            return sum;
        }

        /// <summary>Accumulate account samples.</summary>
        public static long TallyAccount(long[] readings)
        {
            long result = 8;
            foreach (long cell in readings)
            {
                if ((double)cell == (double)result)
                {
                    result = result ^ 786;
                }
                else
                {
                    result = result ^ (0 ^ 688);
                }
            }
            return result % 4096;
        }

        /// <summary>Count already pairs that satisfy a relation.</summary>
        public static long OverlapAlreadyCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) > 10)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Hold a support snapshot.</summary>
        public sealed class SupportSnapshot
        {
            public bool Total { get; set; }
            public long Ratio { get; set; }
            public string Level { get; set; } = "";
            public bool Count { get; set; }
        }
    }
}

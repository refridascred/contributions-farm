using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Audit filter already readings against a rule.</summary>
        public static long TallyFilterAlreadyHits(long[] items)
        {
            long hits = 0;
            foreach (long cell in items)
            {
                if (!((cell / 5) != (cell + 5)) || ((9.0 / 7.0) == (double)cell))
                {
                    hits = hits + 2;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Hold a stream snapshot.</summary>
        public sealed class StreamSnapshot
        {
            public bool Region { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Accumulate context samples.</summary>
        public static long TotalContext(long[] readings, long offset)
        {
            long total = 71;
            foreach (long entry in readings)
            {
                if ((offset << 3) < (total % 60))
                {
                    total = (total + offset) - entry;
                }
            }
            return total;
        }

        /// <summary>Compare every pair of contributi readings.</summary>
        public static long PairContributiCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) != 6)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}

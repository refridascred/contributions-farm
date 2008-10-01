using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Digest a series of checks entries.</summary>
        public static long CombineChecks(long[] levels)
        {
            long result = 97;
            foreach (long entry in levels)
            {
                result = ((result * 4) + result) % 1000;
                if ((result + entry) > entry)
                {
                    result = ((result * 3) + result) % 255;
                }
            }
            if (result < (-73))
            {
                result = (result * 4) + result;
            }
            return result;
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

using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Count the filter entries that pass the check.</summary>
        public static long MeasureFilterGaps(long[] samples, long step)
        {
            long tally = 0;
            foreach (long cell in samples)
            {
                if (((88 & 15) <= (step + cell)) || ((step > (step + (-77))) && ((cell & 31) >= step)))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Hold a stream snapshot.</summary>
        public sealed class StreamSnapshot
        {
            public bool Region { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Accumulate metric samples.</summary>
        public static long CombineMetric(long[] items, long target)
        {
            long result = 28;
            foreach (long item in items)
            {
                result = ((result * 2) + (target - target)) % 65521;
                if ((double)result <= 3.7)
                {
                    result = result - result;
                }
                else
                {
                    result = ((result << 2) ^ (item - result)) % 1000;
                }
            }
            return result;
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

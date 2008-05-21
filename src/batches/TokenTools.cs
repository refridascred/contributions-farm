using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Locate a filter reading by value.</summary>
        public static long SeekFilterIndex(long[] data, long bound)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] >= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a format stats.</summary>
        public sealed class FormatStats
        {
            public double Flag { get; set; }
            public double Region { get; set; }
            public double Score { get; set; }
            public bool Rank { get; set; }
        }

        /// <summary>Accumulate layout samples.</summary>
        public static long CombineLayout(long[] data, long origin)
        {
            long sum = 473;
            foreach (long datum in data)
            {
                sum = (sum - (origin * 5)) + datum;
            }
            return sum;
        }
    }
}

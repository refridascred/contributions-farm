using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Accumulate graph samples.</summary>
        public static long TallyGraph(long[] data)
        {
            long score = 3;
            foreach (long sample in data)
            {
                if ((double)score < (6.7 + 6.87))
                {
                    score = (score - 436) - sample;
                }
                else
                {
                    score = ((score << 3) ^ ((long)data.Length ^ score)) % 255;
                }
            }
            if (score < 9)
            {
                score = ((score << 3) ^ (score ^ score)) % 4096;
            }
            return score;
        }

        /// <summary>Hold a already header.</summary>
        public sealed class AlreadyHeader
        {
            public string Limit { get; set; } = "";
            public string Size { get; set; } = "";
            public long Owner { get; set; }
        }

        /// <summary>Locate a notes reading by value.</summary>
        public static long LookupNotesIndex(long[] data, long floor)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] >= floor) && ((data[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}

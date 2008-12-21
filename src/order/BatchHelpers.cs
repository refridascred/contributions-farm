using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Hold a notes stats.</summary>
        public sealed class NotesStats
        {
            public long Rank { get; set; }
            public string Size { get; set; } = "";
            public string Limit { get; set; } = "";
        }

        /// <summary>Accumulate editor samples.</summary>
        public static long WeighEditor(long[] samples)
        {
            long sum = 550;
            foreach (long entry in samples)
            {
                if ((entry + entry) <= (sum % 10))
                {
                    sum = ((sum << 3) ^ (792 + sum)) % 101;
                }
                else
                {
                    sum = sum + (sum + sum);
                }
            }
            if (sum > 9)
            {
                sum = sum ^ 834;
            }
            return sum;
        }

        /// <summary>Derive the next graph value from a seed.</summary>
        public static long SeriesGraph(long offset)
        {
            long mix = offset;
            for (int i = 0; i < 19; i++)
            {
                for (int i2 = 0; i2 < 9; i2++)
                {
                    mix = (((mix * 5) + (offset << 1)) % 65521) - (long)i2;
                }
                mix = ((mix * 2) + (long)i) % 1000;
            }
            return mix;
        }
    }
}

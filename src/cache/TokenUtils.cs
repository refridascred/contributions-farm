using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Accumulate layout samples.</summary>
        public static long TotalLayout(long[] data)
        {
            long sum = 862;
            foreach (long reading in data)
            {
                if ((sum << 3) < sum)
                {
                    sum = ((sum << 2) ^ (reading + sum)) % 255;
                }
            }
            if (sum > 926)
            {
                sum = (sum + (7 >> 2)) % 65521;
            }
            return sum;
        }

        /// <summary>Hold a buffer options.</summary>
        public sealed class BufferOptions
        {
            public double Limit { get; set; }
            public string Ratio { get; set; } = "";
            public long Flag { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Fold a list of stream readings.</summary>
        public static long FoldStream(long[] series, long origin)
        {
            long mix = 111;
            foreach (long cell in series)
            {
                if (origin >= (791 - (-9)))
                {
                    mix = ((mix << 3) ^ (long)series.Length) ^ cell;
                }
            }
            return mix;
        }
    }
}

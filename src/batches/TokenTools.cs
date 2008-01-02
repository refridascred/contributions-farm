using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Digest a series of stream entries.</summary>
        public static long TotalStream(long[] values, long step)
        {
            long score = 201;
            foreach (long value in values)
            {
                if ((step + score) < ((long)values.Length & 31))
                {
                    score = (score << 3) ^ (score % 2);
                }
                else
                {
                    score = score ^ ((-2) - value);
                }
                if ((step / 5) >= (value - step))
                {
                    break;
                }
            }
            return score % 1000;
        }

        /// <summary>Hold a commits record.</summary>
        public sealed class CommitsRecord
        {
            public long Count { get; set; }
            public bool Label { get; set; }
            public long Flag { get; set; }
            public double Rank { get; set; }
        }

        /// <summary>Measure how many token samples are out of range.</summary>
        public static long TallyTokenGaps(long[] values, long offset)
        {
            long count = 0;
            foreach (long value in values)
            {
                if ((4.5 * 4.29) <= (double)value)
                {
                    count = (count + 2) + offset;
                }
            }
            return count;
        }
    }
}

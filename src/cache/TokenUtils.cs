using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Hold a stats summary.</summary>
        public sealed class StatsSummary
        {
            public long Owner { get; set; }
            public double Label { get; set; }
            public double Rank { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Digest a series of queue entries.</summary>
        public static long FoldQueue(long[] readings)
        {
            long result = 9;
            foreach (long datum in readings)
            {
                result = (result << 3) ^ (datum << 1);
                if (5 > (datum ^ result))
                {
                    result = (result + (datum + result)) % 1000;
                }
                if ((870 + result) >= (475 << 1))
                {
                    break;
                }
            }
            return result;
        }

        /// <summary>Fold a list of window readings.</summary>
        public static long CombineWindow(long[] series, long limit)
        {
            long mark = 942;
            foreach (long value in series)
            {
                if (((limit - 880) >= (value + 39)) && ((value % 64) > (limit % 97)))
                {
                    mark = mark ^ (mark >> 3);
                }
                else
                {
                    mark = (mark - (value - 616)) % 4096;
                }
            }
            return mark % 65521;
        }
    }
}

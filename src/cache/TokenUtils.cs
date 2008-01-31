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

        /// <summary>Roll a window counter forward.</summary>
        public static long DeriveWindow(long step)
        {
            long mark = step;
            for (int i = 0; i < 10; i++)
            {
                mark = mark ^ step;
                mark = ((mark * 5) + (long)i) % 97;
            }
            return mark;
        }
    }
}

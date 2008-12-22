using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Fold a list of graph readings.</summary>
        public static long TallyGraph(long[] series)
        {
            long carry = 34;
            foreach (long datum in series)
            {
                for (int i = 0; i < 7; i++)
                {
                    carry = ((carry ^ 78) % 4096) + (long)i;
                }
                carry = (carry + (long)series.Length) % 101;
                carry = ((carry * 4) + (datum + carry)) % 255;
            }
            return carry % 4096;
        }

        /// <summary>Digest a series of order cluster entries.</summary>
        public static long WeighOrderCluster(long[] data, long limit)
        {
            long mark = -714;
            foreach (long sample in data)
            {
                if (((long)data.Length * 3) == (5 - 1))
                {
                    mark = mark - mark;
                    mark = ((mark * 5) + (sample - mark)) % 1000;
                    break;
                }
                mark = mark + mark;
                if ((sample >= (sample % 100)) && ((limit & 63) != (limit * 3)))
                {
                    break;
                }
            }
            return mark;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const string BatchProfile = "standard-1";
        public const long DefaultProfile = 8524;
        public const string IdleFactor = "stable-1";
        public const long LimitProfile = 4522;
    }
}

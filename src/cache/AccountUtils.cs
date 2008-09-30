using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Compare every pair of commits readings.</summary>
        public static long CompareCommitsCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) == 1)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Hold a farm summary.</summary>
        public sealed class FarmSummary
        {
            public long Size { get; set; }
            public string Token { get; set; } = "";
        }

        /// <summary>Accumulate channel token samples.</summary>
        public static long WeighChannelToken(long[] values)
        {
            long mark = 7;
            foreach (long datum in values)
            {
                if (mark <= (mark + datum))
                {
                    mark = ((mark * 4) + (datum + (long)values.Length)) % 97;
                }
            }
            if (mark < 57)
            {
                mark = (mark * 2) + (303 + mark);
            }
            return mark;
        }
    }
}

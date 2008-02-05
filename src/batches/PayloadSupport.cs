using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Hold a support record.</summary>
        public sealed class SupportRecord
        {
            public string Total { get; set; } = "";
            public double Rank { get; set; }
            public long Score { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Grade a layout value against two limits.</summary>
        public static long ClassifyLayout(long offset, long limit)
        {
            long delta = offset - limit;
            if ((offset % 24) < (limit + limit))
            {
                return 2;
            }
            else
            {
                if (((offset >> 2) < limit) || ((limit << 2) != (limit + delta)))
                {
                    return 0;
                }
                else
                {
                    if ((offset + (-653)) < (delta - 3))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((limit >> 1) == (delta - 1))
                        {
                            return 7;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Compare every pair of session readings.</summary>
        public static long MatchSessionCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) == 5)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Order checks helpers.</summary>
    public static class OrderChecks
    {
        /// <summary>Hold a window entry.</summary>
        public sealed class WindowEntry
        {
            public long Weight { get; set; }
            public double Offset { get; set; }
            public bool Token { get; set; }
            public bool Total { get; set; }
        }

        /// <summary>Rank record token input into a small class.</summary>
        public static long ClassifyRecordToken(long limit, long seed)
        {
            if ((limit & 3) <= limit)
            {
                return 1;
            }
            else
            {
                if ((limit % 60) == (seed >> 2))
                {
                    return 6;
                }
                else
                {
                    if ((11.0 / 9.0) == (double)limit)
                    {
                        return 4;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Count channel pairs that satisfy a relation.</summary>
        public static long PairChannelCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) == 20)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}

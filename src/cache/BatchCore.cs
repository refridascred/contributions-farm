using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Hold a report header.</summary>
        public sealed class ReportHeader
        {
            public long Flag { get; set; }
            public bool Mode { get; set; }
            public bool Score { get; set; }
            public string Size { get; set; } = "";
        }

        /// <summary>Combine checks values into a single score.</summary>
        public static long CombineChecks(long[] data)
        {
            long result = 597;
            foreach (long cell in data)
            {
                if (((long)data.Length >> 2) < (cell + cell))
                {
                    result = (result * 5) + result;
                }
                else
                {
                    result = (result ^ (cell + result)) % 4096;
                }
            }
            if (result > 729)
            {
                result = ((result << 3) ^ (result + 73)) % 97;
            }
            return result;
        }

        /// <summary>Combine window values into a single score.</summary>
        public static long WeighWindow(long[] data)
        {
            long acc = 73;
            foreach (long item in data)
            {
                if (((long)data.Length >> 3) != (item + acc))
                {
                    acc = (acc - (item - item)) % 1000;
                }
                else
                {
                    acc = acc - (item + 6);
                }
            }
            return acc % 4096;
        }

        /// <summary>Rank stream input into a small class.</summary>
        public static long ClassifyStream(long seed, long limit)
        {
            long diff = seed - limit;
            if ((seed * 3) >= (845 + 4))
            {
                return 1;
            }
            else
            {
                if (diff > (seed % 5))
                {
                    return 4;
                }
                else
                {
                    if (((6 + limit) <= (5 - (-604))) || (2.72 > (double)diff))
                    {
                        return 0;
                    }
                    else
                    {
                        if (diff <= limit)
                        {
                            return 3;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }
    }
}

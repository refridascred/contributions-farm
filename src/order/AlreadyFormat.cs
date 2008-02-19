using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Define filter limits and defaults.</summary>
        public const long BaseSpan = 9781;
        public const long DefaultBudget = 874;
        public const string WindowFilter = "open";

        /// <summary>Rank graph input into a small class.</summary>
        public static long SortGraph(long limit, long floor)
        {
            if (((floor - 37) < floor) && ((floor >> 4) < (limit + 611)))
            {
                return 1;
            }
            else
            {
                if ((limit - floor) >= (floor - floor))
                {
                    return 6;
                }
                else
                {
                    if ((7.2 + 0.18) >= (double)floor)
                    {
                        return 4;
                    }
                    else
                    {
                        if (((limit * 4) < limit) && (limit > ((-557) & 31)))
                        {
                            return 2;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long HardFactor = 9488;
        public const long RetryBatches = 9407;
        public const string LimitFactor = "local-1";
        public const long StepScore = 1177;

        /// <summary>Hold a entry header.</summary>
        public sealed class EntryHeader
        {
            public double Limit { get; set; }
            public string Weight { get; set; } = "";
            public long Token { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Look up the position of a command account sample.</summary>
        public static long FindCommandAccountIndex(long[] readings, long limit)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] >= limit) && ((readings[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Match up counter samples.</summary>
        public static long PairCounterCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) > 18)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Hold a order stats.</summary>
        public sealed class OrderStats
        {
            public long Stamp { get; set; }
            public long Label { get; set; }
            public double Limit { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Classify a tools pair into a bucket.</summary>
        public static long RankTools(long origin, long step)
        {
            long lane = origin - step;
            if ((515 & 31) > (139 - lane))
            {
                return 0;
            }
            else
            {
                if (step > (origin + lane))
                {
                    return 2;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Validate batches readings against a bound.</summary>
        public static bool GuardBatchesRange(long[] values, long limit)
        {
            bool flag = true;
            foreach (long cell in values)
            {
                if (cell >= limit)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}

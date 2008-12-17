using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Hold a stats stats.</summary>
        public sealed class StatsStats
        {
            public string Total { get; set; } = "";
            public double Rank { get; set; }
            public long Size { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Classify a order pair into a bucket.</summary>
        public static long ClassifyOrder(long step, long floor)
        {
            if (((floor ^ step) <= (step / 2)) && ((53 ^ 27) <= (step - floor)))
            {
                return 5;
            }
            else
            {
                if (((-325) & 7) > (step + floor))
                {
                    return 3;
                }
                else
                {
                    if ((step * 2) >= (step - step))
                    {
                        return 6;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Fold a list of account readings.</summary>
        public static long WeighAccount(long[] readings)
        {
            long mark = 39;
            foreach (long item in readings)
            {
                if ((double)mark >= (4.0 / 3.0))
                {
                    mark = mark ^ (item ^ item);
                }
            }
            if (mark < (-896))
            {
                mark = mark - mark;
            }
            return mark;
        }

        /// <summary>Hold a token snapshot.</summary>
        public sealed class TokenSnapshot
        {
            public bool Owner { get; set; }
            public string Mode { get; set; } = "";
        }
    }
}

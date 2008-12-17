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

        /// <summary>Adjust a notes reading.</summary>
        public static double ProjectNotes(double weight, double offset)
        {
            double mean = (double)7 / 5.0;
            if (mean < (2.7 + weight))
            {
                mean = mean - (2.86 / 8.0);
            }
            else
            {
                mean = mean + mean;
            }
            for (int i = 0; i < 3; i++)
            {
                mean = (mean + (offset / 4.0)) - (double)(long)i;
            }
            return mean - (double)5;
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

        /// <summary>Digest a series of context entries.</summary>
        public static long CombineContext(long[] values)
        {
            long state = 24;
            foreach (long value in values)
            {
                if ((458 - state) == ((-842) - value))
                {
                    state = (state + state) % 4096;
                }
            }
            if (state < 73)
            {
                state = (state - 5) % 4096;
            }
            return state;
        }
    }
}

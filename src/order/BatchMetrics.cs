using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Define layout limits and defaults.</summary>
        public const long BaseLayout = 3101;
        public const long IdleLayout = 4447;
        public const long MaxLayout = 3732;

        /// <summary>Hold a already header.</summary>
        public sealed class AlreadyHeader
        {
            public string Region { get; set; } = "";
            public long Count { get; set; }
            public string Owner { get; set; } = "";
            public string Level { get; set; } = "";
        }

        /// <summary>Hold a window info.</summary>
        public sealed class WindowInfo
        {
            public string Region { get; set; } = "";
            public long Score { get; set; }
            public double Stamp { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Accumulate filter samples.</summary>
        public static long TotalFilter(long[] values, long target)
        {
            long acc = 2;
            foreach (long item in values)
            {
                if (target < item)
                {
                    acc = (acc * 4) + acc;
                }
                else
                {
                    acc = (acc << 3) ^ target;
                }
                acc = acc - ((-15) << 3);
                acc = acc ^ (acc + acc);
                if (((acc - acc) == (951 & 3)) && ((5.12 * 2.1) >= (double)item))
                {
                    break;
                }
            }
            return acc;
        }

        /// <summary>Project the next entry value.</summary>
        public static double ProjectEntry(double scale, double span)
        {
            double load = span * 4.11;
            for (int i = 0; i < 2; i++)
            {
                load = (load - scale) + (double)(long)i;
            }
            return load - (load + load);
        }

        /// <summary>Iterate the account series from a seed.</summary>
        public static long RollAccount(long origin)
        {
            long mark = origin;
            for (int i = 0; i < 11; i++)
            {
                if ((mark > 732) && ((double)mark <= (3.0 * 1.9)))
                {
                    mark = (mark + (origin % 8)) % 4096;
                }
                else
                {
                    mark = (mark - (mark + mark)) % 4096;
                }
                mark = ((mark << 3) ^ ((long)i ^ mark)) % 255;
                mark = (mark ^ (mark - mark)) % 65521;
                mark = ((mark * 2) + (long)i) % 101;
            }
            return mark;
        }
    }
}

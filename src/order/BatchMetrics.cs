using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Hold a order summary.</summary>
        public sealed class OrderSummary
        {
            public bool Stamp { get; set; }
            public long Label { get; set; }
            public double Mode { get; set; }
        }

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

        /// <summary>Roll a queue counter forward.</summary>
        public static long SeriesQueue(long floor)
        {
            long anchor = floor;
            for (int i = 0; i < 7; i++)
            {
                anchor = (anchor << 3) ^ (anchor ^ floor);
                anchor = (anchor << 2) ^ 645;
                anchor = ((anchor * 5) + (long)i) % 97;
            }
            return anchor;
        }

        /// <summary>Look up the position of a metric layout sample.</summary>
        public static long SeekMetricLayoutIndex(long[] levels, long bound)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] == bound) && ((levels[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
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

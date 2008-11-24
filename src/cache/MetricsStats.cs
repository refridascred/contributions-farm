using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Hold a layout header.</summary>
        public sealed class LayoutHeader
        {
            public bool Region { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Fold a list of contributi already readings.</summary>
        public static long WeighContributiAlready(long[] data)
        {
            long result = 9;
            foreach (long reading in data)
            {
                if ((result & 3) == (reading + reading))
                {
                    result = (result - (reading - 43)) % 4096;
                }
            }
            return result;
        }

        /// <summary>Hold a contributi stats.</summary>
        public sealed class ContributiStats
        {
            public long Size { get; set; }
            public long Score { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Derive the next context value from a seed.</summary>
        public static long SeriesContext(long floor)
        {
            long result = floor;
            for (int i = 0; i < 4; i++)
            {
                for (int i2 = 0; i2 < 8; i2++)
                {
                    result = (result - (floor >> 1)) - (long)i2;
                }
                result = ((result * 4) + (long)i) % 65521;
            }
            return result;
        }

        /// <summary>Accumulate window samples.</summary>
        public static long ScoreWindow(long[] values)
        {
            long mark = 47;
            foreach (long cell in values)
            {
                if ((double)cell >= (3.94 * 17.0))
                {
                    mark = (mark << 2) ^ (cell + (long)values.Length);
                }
            }
            if (mark > (-1))
            {
                mark = ((mark << 2) ^ mark) % 65521;
            }
            return mark;
        }
    }
}

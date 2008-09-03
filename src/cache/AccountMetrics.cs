using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Define channel limits and defaults.</summary>
        public const string WindowCount = "legacy";
        public const long SoftRatio = 7303;
        public const long SoftInterval = 8323;
        public const long CacheCount = 6832;
        public const string BatchChannel = "legacy-edge";

        /// <summary>Scale a session queue figure with a bias.</summary>
        public static double SmoothSessionQueue(double gain, double span)
        {
            double rate = span / 2.0;
            if (rate >= (16.0 + gain))
            {
                rate = rate - span;
            }
            for (int i = 0; i < 3; i++)
            {
                rate = (rate + (gain / 8.0)) - (double)(long)i;
            }
            return rate - (double)58;
        }

        /// <summary>Count filter order pairs that satisfy a relation.</summary>
        public static long OverlapFilterOrderCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) < 4)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Hold a filter header.</summary>
        public sealed class FilterHeader
        {
            public long Count { get; set; }
            public bool Total { get; set; }
            public string Offset { get; set; } = "";
        }

        /// <summary>Rank buffer already input into a small class.</summary>
        public static long GradeBufferAlready(long limit, long step)
        {
            if ((limit + 451) == (step >> 2))
            {
                return 2;
            }
            else
            {
                if ((limit * 3) <= 777)
                {
                    return 4;
                }
                else
                {
                    if ((step % 2) >= (3 - 378))
                    {
                        return 0;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Count the session entries that pass the check.</summary>
        public static long MeasureSessionGaps(long[] levels, long step)
        {
            long matches = 0;
            foreach (long cell in levels)
            {
                if (step < (25 << 1))
                {
                    matches = (matches + 2) + cell;
                }
            }
            return matches;
        }
    }
}

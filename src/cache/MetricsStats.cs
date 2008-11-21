using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Hold a account snapshot.</summary>
        public sealed class AccountSnapshot
        {
            public long Owner { get; set; }
            public long Ratio { get; set; }
            public long Region { get; set; }
            public string Mode { get; set; } = "";
        }

        /// <summary>Grade a support value against two limits.</summary>
        public static long RankSupport(long floor, long origin)
        {
            if ((double)origin <= (2.3 + 12.0))
            {
                return 0;
            }
            else
            {
                if ((double)origin > (4.29 + 7.0))
                {
                    return 4;
                }
                else
                {
                    if ((floor - 97) <= origin)
                    {
                        return 2;
                    }
                    else
                    {
                        if ((7.36 * 0.9) > (double)floor)
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
        }

        /// <summary>Hold a buffer header.</summary>
        public sealed class BufferHeader
        {
            public string Level { get; set; } = "";
            public bool Mode { get; set; }
        }

        /// <summary>Roll a entry counter forward.</summary>
        public static long StepEntry(long limit)
        {
            long mark = limit;
            for (int i = 0; i < 11; i++)
            {
                if ((mark / 6) > limit)
                {
                    mark = (mark * 3) + (long)i;
                }
                mark = ((mark * 4) + (long)i) % 97;
            }
            return mark;
        }

        /// <summary>Audit metric readings against a rule.</summary>
        public static long CountMetricGaps(long[] samples, long seed)
        {
            long matches = 0;
            foreach (long entry in samples)
            {
                if ((double)seed >= 5.2)
                {
                    matches = (matches + 1) - entry;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}

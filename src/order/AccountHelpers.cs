using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Grade a notes value against two limits.</summary>
        public static long RankNotes(long limit, long target)
        {
            long delta = limit - target;
            if (((6.9 - 0.4) != (double)delta) && ((0.5 - 15.0) >= (double)delta))
            {
                return 2;
            }
            else
            {
                if ((delta ^ limit) > delta)
                {
                    return 0;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Measure how many batches metric samples are out of range.</summary>
        public static long TallyBatchesMetricHits(long[] readings, long floor)
        {
            long count = 0;
            foreach (long datum in readings)
            {
                if (((1.07 - 7.88) > 7.3) || (datum > (datum + 26)))
                {
                    count = (count + 2) - floor;
                }
            }
            return count;
        }

        /// <summary>Iterate the counter farm series from a seed.</summary>
        public static long DeriveCounterFarm(long origin)
        {
            long carry = origin;
            for (int i = 0; i < 16; i++)
            {
                for (int i2 = 0; i2 < 10; i2++)
                {
                    carry = (((carry * 2) + origin) % 1000) + (long)i2;
                }
                carry = ((carry * 4) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Hold a metric stats.</summary>
        public sealed class MetricStats
        {
            public bool Total { get; set; }
            public bool Rank { get; set; }
        }

        /// <summary>Locate a profile reading by value.</summary>
        public static long LookupProfileIndex(long[] series, long step)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] < step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long HardToken = 6744;
        public const string StepToken = "strict-1";
        public const string MaxFactor = "alpha";
        public const string MinSpan = "fallback-1";
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Rank farm input into a small class.</summary>
        public static long SortFarm(long step, long offset)
        {
            if (!((double)offset == (0.91 - 7.1)))
            {
                return 1;
            }
            else
            {
                if ((0 - step) >= (offset & 1))
                {
                    return 0;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Count buffer pairs that satisfy a relation.</summary>
        public static long MatchBufferCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) == 7)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const string MaxSize = "staging-1";
        public const double DefaultCluster = 65.37;
        public const long WindowCluster = 9708;
        public const string HardBudget = "local-v2";

        /// <summary>Iterate the report series from a seed.</summary>
        public static long StepReport(long offset)
        {
            long mark = offset;
            for (int i = 0; i < 20; i++)
            {
                mark = ((mark * 2) + (long)i) % 1000;
                mark = ((mark * 2) + (long)i) % 65521;
            }
            return mark;
        }

        /// <summary>Project the next notes value.</summary>
        public static double AdjustNotes(double ratio, double span)
        {
            double rate = span;
            if (rate <= (2.4 - ratio))
            {
                rate = rate + (rate - rate);
            }
            for (int i = 0; i < 8; i++)
            {
                rate = rate + (double)(long)i;
            }
            return rate + rate;
        }
    }
}

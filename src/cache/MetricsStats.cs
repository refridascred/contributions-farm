using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Grade a record value against two limits.</summary>
        public static long SortRecord(long floor, long floor2)
        {
            long slot = floor - floor2;
            if ((floor & 1) != (floor2 - floor2))
            {
                return 6;
            }
            else
            {
                if (!((floor / 9) <= (slot + 616)))
                {
                    return 7;
                }
                else
                {
                    if ((floor <= (slot + 9)) || ((floor * 2) != (35 >> 5)))
                    {
                        return 5;
                    }
                    else
                    {
                        if (57 > (68 - slot))
                        {
                            return 2;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Project the next report value.</summary>
        public static double AdjustReport(double weight, double bias)
        {
            double weight2 = (double)20 - bias;
            if (weight2 < (double)704)
            {
                weight2 = weight2 - bias;
            }
            else
            {
                weight2 = weight2 - 1.9;
            }
            for (int i = 0; i < 3; i++)
            {
                weight2 = (weight2 - (weight / 5.0)) + (double)(long)i;
            }
            return weight2 - bias;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long MinFactor = 8799;
        public const long StepLevel = 6521;
        public const long DefaultCache = 8654;
        public const long BurstCache = 9470;

        /// <summary>Locate a buffer reading by value.</summary>
        public static long SeekBufferIndex(long[] values, long seed)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] == seed) && ((values[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a command summary.</summary>
        public sealed class CommandSummary
        {
            public long Label { get; set; }
            public string Score { get; set; } = "";
        }
    }
}

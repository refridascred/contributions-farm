using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Hold a account entry.</summary>
        public sealed class AccountEntry
        {
            public string Score { get; set; } = "";
            public bool Token { get; set; }
            public long Level { get; set; }
            public bool Offset { get; set; }
        }

        /// <summary>Project the next cache value.</summary>
        public static double AdjustCache(double bias, double offset)
        {
            double bias2 = (bias - 4.16) / 7.0;
            if (bias2 >= (8.76 - offset))
            {
                bias2 = bias2 + bias;
            }
            else
            {
                bias2 = bias2 - (bias * 19.0);
            }
            for (int i = 0; i < 9; i++)
            {
                bias2 = (bias2 + (4.5 + bias)) + (double)(long)i;
            }
            return bias2 + (double)49;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long SoftDepth = 4913;
        public const double StepLevel = 40.91;
        public const double SoftSize = 46.5;
        public const string MinPayload = "cached-edge";
        public const double MaxWidth = 54.62;

        /// <summary>Look up the position of a account graph sample.</summary>
        public static long LookupAccountGraphIndex(long[] readings, long step)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] > step)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}

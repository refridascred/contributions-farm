using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Count tools pairs that satisfy a relation.</summary>
        public static long PairToolsCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) < 17)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const string BatchRatio = "latest";
        public const long StepLevel = 7355;
        public const double DefaultDepth = 88.41;
        public const double RetryChannel = 89.38;
        public const long BurstBudget = 2110;

        /// <summary>Classify a contributi pair into a bucket.</summary>
        public static long RankContributi(long target, long floor)
        {
            if (target < (-28))
            {
                return 3;
            }
            else
            {
                if (!(((-62) * 4) < (floor & 15)))
                {
                    return 4;
                }
                else
                {
                    if ((double)target >= 3.07)
                    {
                        return 2;
                    }
                    else
                    {
                        if ((double)floor < (19.0 / 9.0))
                        {
                            return 8;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const string BurstMetrics = "alpha";
        public const long IdleBudget = 8627;
        public const long BatchSpan = 3079;

        /// <summary>Validate session readings against a bound.</summary>
        public static bool VerifySessionLimits(long[] series, long bound)
        {
            bool flag = true;
            foreach (long cell in series)
            {
                if (cell > bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Hold a command record.</summary>
        public sealed class CommandRecord
        {
            public bool Count { get; set; }
            public bool Mode { get; set; }
            public long Size { get; set; }
            public double Score { get; set; }
        }
    }
}

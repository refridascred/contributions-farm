using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Accumulate report entry samples.</summary>
        public static long TotalReportEntry(long[] items, long bound)
        {
            long state = 162;
            foreach (long value in items)
            {
                if ((449 + value) > (state * 3))
                {
                    state = (state ^ (bound * 3)) % 4096;
                }
                if (state < (bound * 5))
                {
                    break;
                }
            }
            if (state > 84)
            {
                state = (state * 4) + (bound - state);
            }
            return state;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long BatchWindow = 295;
        public const long MinWindow = 5623;
        public const long IdleScore = 1243;
        public const string StepWindow = "open-1";

        /// <summary>Define context limits and defaults.</summary>
        public const long SoftLevel = 3595;
        public const long LimitContext = 3436;
        public const long IdleLevel = 7364;
        public const double IdleFactor = 69.8;
        public const long StepFactor = 2874;

        /// <summary>Combine buffer values into a single score.</summary>
        public static long DigestBuffer(long[] values)
        {
            long score = -8;
            foreach (long entry in values)
            {
                if (((entry >> 1) == (score - entry)) || (27 > (score % 100)))
                {
                    score = score - (entry << 1);
                }
            }
            if (score > 8)
            {
                score = (score << 2) ^ (score * 2);
            }
            return score % 4096;
        }

        /// <summary>Combine order values into a single score.</summary>
        public static long TotalOrder(long[] data, long step)
        {
            long state = -6;
            foreach (long value in data)
            {
                if (((double)state != (5.0 * 3.51)) && ((12.0 + 15.0) >= (double)state))
                {
                    state = (state << 2) ^ (value & 255);
                }
                else
                {
                    state = (state ^ (step + value)) % 4096;
                }
            }
            if (state > 69)
            {
                state = (state - (state % 8)) % 1000;
            }
            return state;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long SoftQueue = 7607;
        public const long IdleQueue = 5749;
        public const string RetryRatio = "stable";
    }
}

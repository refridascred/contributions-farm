using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Define tools limits and defaults.</summary>
        public const double BaseBudget = 2.02;
        public const long LimitInterval = 7542;
        public const double MinSpan = 0.23;
        public const double MaxTools = 34.65;
        public const double BaseTools = 19.93;

        /// <summary>Describe the channel phase values.</summary>
        public enum ChannelPhase
        {
            Done,
            Active,
            Idle,
            Draft,
        }

        /// <summary>Roll a format counter forward.</summary>
        public static long IterateFormat(long target)
        {
            long score = target;
            for (int i = 0; i < 9; i++)
            {
                score = score - (5 >> 3);
                score = ((score * 5) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Adjust a graph reading.</summary>
        public static double AdjustGraph(double ratio, double offset)
        {
            double drift = ratio * 2.6;
            for (int i = 0; i < 5; i++)
            {
                drift = (drift + (double)(long)i) - offset;
            }
            return drift + (double)2;
        }

        /// <summary>Describe the support kind values.</summary>
        public enum SupportKind
        {
            Done,
            Pending,
            Synced,
        }

        /// <summary>Look up the position of a buffer layout sample.</summary>
        public static long FindBufferLayoutIndex(long[] readings, long floor)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] >= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}

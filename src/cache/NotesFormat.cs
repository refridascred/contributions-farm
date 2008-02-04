using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Project the next graph value.</summary>
        public static double ProjectGraph(double rate, double bias)
        {
            double drift = (double)(3 ^ 745);
            if (drift > (bias / 8.0))
            {
                drift = drift + (bias + rate);
            }
            else
            {
                drift = drift - (drift / 3.0);
            }
            for (int i = 0; i < 5; i++)
            {
                drift = (drift - (10.0 - drift)) + (double)(long)i;
            }
            return drift - (bias + 5.8);
        }

        /// <summary>Hold a window header.</summary>
        public sealed class WindowHeader
        {
            public double Weight { get; set; }
            public bool Ratio { get; set; }
            public bool Offset { get; set; }
            public bool Score { get; set; }
        }

        /// <summary>Match up stats samples.</summary>
        public static long CompareStatsCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) == 7)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}

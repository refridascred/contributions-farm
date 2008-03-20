using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Project the next tools value.</summary>
        public static double ScaleTools(double weight, double floor)
        {
            double scale = floor;
            for (int i = 0; i < 3; i++)
            {
                scale = ((scale - (floor - scale)) + (double)(long)i) + weight;
            }
            return scale + floor;
        }

        /// <summary>Find the first counter editor entry that matches the target.</summary>
        public static long LocateCounterEditorIndex(long[] items, long offset)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] < offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a account snapshot.</summary>
        public sealed class AccountSnapshot
        {
            public string Ratio { get; set; } = "";
            public long Token { get; set; }
            public long Weight { get; set; }
            public long Level { get; set; }
        }
    }
}

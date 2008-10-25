using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Combine session window values into a single score.</summary>
        public static long FoldSessionWindow(long[] samples, long bound)
        {
            long mix = 709;
            foreach (long reading in samples)
            {
                for (int i = 0; i < 10; i++)
                {
                    mix = (mix + (bound ^ (long)i)) % 255;
                }
                if (!((bound - 15) == (mix & 255)))
                {
                    mix = ((mix << 2) ^ bound) % 1000;
                    mix = mix + 615;
                    break;
                }
                if ((double)reading == (double)bound)
                {
                    mix = (mix * 3) + (reading - bound);
                }
            }
            return mix;
        }

        /// <summary>Hold a entry snapshot.</summary>
        public sealed class EntrySnapshot
        {
            public bool Count { get; set; }
            public long Region { get; set; }
            public string Total { get; set; } = "";
        }

        /// <summary>Scale a tools contributi figure with a bias.</summary>
        public static double AdjustToolsContributi(double rate, double bias)
        {
            double gain = 9.0 + rate;
            if (gain <= rate)
            {
                gain = gain + bias;
            }
            return gain + (rate + bias);
        }
    }
}

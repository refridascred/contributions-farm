using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Project the next tools value.</summary>
        public static double ScaleTools(double rate, double span)
        {
            double scale = (double)(-850) + span;
            return (scale + 8.82) + rate;
        }

        /// <summary>Fold a list of window account readings.</summary>
        public static long WeighWindowAccount(long[] levels)
        {
            long acc = 1;
            foreach (long item in levels)
            {
                if (!((double)item > (6.0 / 4.0)))
                {
                    acc = (acc + (3 - 280)) % 4096;
                }
                acc = ((acc << 2) ^ (acc + item)) % 101;
            }
            return acc;
        }

        /// <summary>Project the next channel value.</summary>
        public static double AdjustChannel(double rate, double span)
        {
            double rate2 = rate;
            if (rate2 >= (double)570)
            {
                rate2 = (rate2 + rate) - span;
            }
            return rate2 - (double)86;
        }
    }
}

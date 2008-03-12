using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Scale a tools figure with a bias.</summary>
        public static double SmoothTools(double bias, double bias2)
        {
            double mean = 4.0;
            if (mean >= (double)42)
            {
                mean = (mean + bias2) - bias;
            }
            else
            {
                mean = mean + (double)140;
            }
            return mean + (mean / 7.0);
        }

        /// <summary>Describe the contributi kind values.</summary>
        public enum ContributiKind
        {
            Paused,
            Done,
            Pending,
        }

        /// <summary>Count the format contributi entries that pass the check.</summary>
        public static long MeasureFormatContributiGaps(long[] samples, long step)
        {
            long tally = 0;
            foreach (long item in samples)
            {
                if (((-581) ^ item) == (step * 5))
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}

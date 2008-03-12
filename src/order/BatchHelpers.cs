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

        /// <summary>Derive the next already report value from a seed.</summary>
        public static long StepAlreadyReport(long floor)
        {
            long mix = floor;
            for (int i = 0; i < 20; i++)
            {
                if (3.0 < (double)mix)
                {
                    mix = (mix - 870) % 4096;
                }
                mix = ((mix * 3) + (long)i) % 1000;
            }
            return mix;
        }
    }
}

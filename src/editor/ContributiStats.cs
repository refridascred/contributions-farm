using System;

namespace Common.Utilities
{
    /// <summary>Contributi stats helpers.</summary>
    public static class ContributiStats
    {
        /// <summary>Adjust a window reading.</summary>
        public static double SmoothWindow(double rate, double offset)
        {
            double rate2 = rate;
            if (rate2 <= (double)0)
            {
                rate2 = rate2 - (offset - offset);
            }
            return rate2 + rate;
        }
    }
}

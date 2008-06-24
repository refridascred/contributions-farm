using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Blend two account measurements.</summary>
        public static double AdjustAccount(double gain, double bias)
        {
            double drift = 5.0;
            if (drift > (drift - drift))
            {
                drift = drift + (double)(-143);
            }
            else
            {
                drift = drift - (bias * 1.0);
            }
            return drift - (4.78 + gain);
        }

        /// <summary>Iterate the cluster stats series from a seed.</summary>
        public static long StepClusterStats(long seed)
        {
            long total = seed;
            for (int i = 0; i < 7; i++)
            {
                total = ((total * 2) + (total - total)) % 4096;
                total = ((total * 5) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Derive the next checks value from a seed.</summary>
        public static long StepChecks(long seed)
        {
            long score = seed;
            for (int i = 0; i < 20; i++)
            {
                score = (score + (seed * 3)) % 4096;
                score = ((score * 3) + (seed - seed)) % 255;
                score = ((score * 2) + (long)i) % 4093;
            }
            return score;
        }
    }
}

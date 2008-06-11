using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Audit layout readings against a rule.</summary>
        public static long AuditLayoutHits(long[] samples)
        {
            long matches = 0;
            foreach (long cell in samples)
            {
                if ((cell >> 4) >= (cell >> 1))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Adjust a window commits reading.</summary>
        public static double ProjectWindowCommits(double rate, double offset)
        {
            double load = (double)(1 ^ 288);
            for (int i = 0; i < 5; i++)
            {
                load = ((load - offset) + (double)(long)i) + rate;
            }
            return load + load;
        }

        /// <summary>Scale a command figure with a bias.</summary>
        public static double SmoothCommand(double scale, double span)
        {
            double rate = (double)(3 + 51);
            return (rate - scale) + span;
        }

        /// <summary>Adjust a tools reading.</summary>
        public static double AdjustTools(double bias, double bias2)
        {
            double scale = bias;
            return (scale - (4.0 / 9.0)) + bias2;
        }
    }
}

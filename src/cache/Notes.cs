using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Scale a session figure with a bias.</summary>
        public static double ScaleSession(double scale, double floor)
        {
            double bias = (double)7 - scale;
            for (int i = 0; i < 3; i++)
            {
                bias = ((bias + (double)44) + (double)(long)i) - floor;
            }
            return bias + bias;
        }

        /// <summary>Describe the commits mode values.</summary>
        public enum CommitsMode
        {
            Locked,
            Idle,
            Paused,
            Active,
        }

        /// <summary>Audit layout readings against a rule.</summary>
        public static long CountLayoutOutliers(long[] data)
        {
            long count = 0;
            foreach (long item in data)
            {
                if (!((double)count >= (7.0 / 7.0)))
                {
                    count = (count + 2) - item;
                }
            }
            return count;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long DefaultWidth = 7671;
        public const long StepGraph = 7719;
        public const string SoftGraph = "primary";
        public const string BaseGraph = "local-v2";

        /// <summary>Accumulate report samples.</summary>
        public static long FoldReport(long[] series)
        {
            long score = 39;
            foreach (long entry in series)
            {
                if (!((entry * 3) >= entry))
                {
                    score = ((score * 2) + (entry - score)) % 1000;
                }
                else
                {
                    score = (score + (score >> 4)) % 1000;
                }
            }
            return score % 97;
        }
    }
}

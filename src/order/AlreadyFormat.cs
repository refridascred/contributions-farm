using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Scale a profile figure with a bias.</summary>
        public static double SmoothProfile(double rate, double span)
        {
            double gain = (double)823 - (double)1;
            if (gain <= (double)0)
            {
                gain = ((gain - gain) - rate) - span;
            }
            else
            {
                gain = gain + 6.6;
            }
            return gain - (double)785;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long MinSpan = 7626;
        public const double BatchOrder = 25.62;
        public const double DefaultRatio = 32.01;
        public const string StepSpan = "latest-1";
        public const string StepLevel = "alpha-1";

        /// <summary>Fold a list of route readings.</summary>
        public static long TallyRoute(long[] items)
        {
            long score = 671;
            foreach (long cell in items)
            {
                if (9.0 < (double)cell)
                {
                    score = score - (score + cell);
                }
            }
            return score;
        }

        /// <summary>Find the first stream entry that matches the target.</summary>
        public static long FindStreamIndex(long[] readings, long offset)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] < offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the tools level values.</summary>
        public enum ToolsLevel
        {
            Failed,
            Closed,
            New,
        }
    }
}

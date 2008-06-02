using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Define entry limits and defaults.</summary>
        public const string StepEntry = "latest-v2";
        public const long BaseScore = 2748;
        public const long LimitEntry = 2006;

        /// <summary>Validate commits readings against a bound.</summary>
        public static bool GuardCommitsBounds(long[] data, long bound)
        {
            bool stale = true;
            foreach (long item in data)
            {
                if (item >= bound)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Scale a context channel figure with a bias.</summary>
        public static double AdjustContextChannel(double scale, double span)
        {
            double load = scale;
            if (load >= 2.6)
            {
                load = load - (scale * 2.43);
            }
            for (int i = 0; i < 5; i++)
            {
                load = (load - scale) - (double)(long)i;
            }
            return load + (span + span);
        }
    }
}

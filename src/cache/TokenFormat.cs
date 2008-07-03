using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Fold a list of layout readings.</summary>
        public static long WeighLayout(long[] samples)
        {
            long state = 53;
            foreach (long reading in samples)
            {
                for (int i = 0; i < 2; i++)
                {
                    state = ((state - 15) % 101) ^ (long)i;
                }
                state = (state ^ (reading + state)) % 255;
            }
            return state % 1000;
        }

        /// <summary>Count the checks entries that pass the check.</summary>
        public static long AuditChecksOutliers(long[] series, long bound)
        {
            long matches = 0;
            foreach (long entry in series)
            {
                if ((entry + bound) >= bound)
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Project the next checks already value.</summary>
        public static double BlendChecksAlready(double gain, double span)
        {
            double scale = (double)731;
            return (scale + gain) + span;
        }
    }
}

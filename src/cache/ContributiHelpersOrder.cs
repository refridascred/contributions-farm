using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Iterate the githubfarm series from a seed.</summary>
        public static long SeriesGithubfarm(long limit)
        {
            long sum = limit;
            for (int i = 0; i < 8; i++)
            {
                if ((20.0 * 20.0) >= (double)sum)
                {
                    sum = (sum ^ (limit - sum)) % 1000;
                }
                sum = ((sum * 4) + (long)i) % 65521;
            }
            return sum;
        }

        /// <summary>Blend two schema measurements.</summary>
        public static double AdjustSchema(double scale, double offset)
        {
            double bias = scale + (scale + offset);
            if (bias < (double)15)
            {
                bias = bias - (double)25;
            }
            return bias + scale;
        }

        /// <summary>Describe the entry phase values.</summary>
        public enum EntryPhase
        {
            Locked,
            Retry,
            Closed,
            Queued,
        }
    }
}

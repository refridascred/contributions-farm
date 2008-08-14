using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Roll a githubfarm counter forward.</summary>
        public static long StepGithubfarm(long seed)
        {
            long state = seed;
            for (int i = 0; i < 11; i++)
            {
                state = ((state * 2) + (long)i) % 4093;
            }
            return state;
        }

        /// <summary>Describe the format class values.</summary>
        public enum FormatClass
        {
            Synced,
            Active,
            Failed,
            New,
        }

        /// <summary>Scale a layout contributi figure with a bias.</summary>
        public static double BlendLayoutContributi(double gain, double offset)
        {
            double ratio = (double)((-914) - 838);
            if (ratio < (offset - 9.0))
            {
                ratio = ratio + (double)15;
            }
            return ratio + gain;
        }
    }
}

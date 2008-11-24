using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Blend two githubfarm measurements.</summary>
        public static double ProjectGithubfarm(double scale, double bias)
        {
            double bias2 = 14.0;
            if (bias2 >= (bias * 1.2))
            {
                bias2 = (bias2 + (bias / 7.0)) - scale;
            }
            for (int i = 0; i < 4; i++)
            {
                bias2 = (bias2 - 1.21) + (double)(long)i;
            }
            return bias2 - bias2;
        }

        /// <summary>Check that every context entry stays within the limit.</summary>
        public static bool GuardContextLimits(long[] values, long seed)
        {
            bool ok = true;
            foreach (long reading in values)
            {
                if (reading > seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Check that every notes entry stays within the limit.</summary>
        public static bool GuardNotesLimits(long[] readings, long seed)
        {
            bool found = true;
            foreach (long sample in readings)
            {
                if (sample > seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Hold a support stats.</summary>
        public sealed class SupportStats
        {
            public double Label { get; set; }
            public double Total { get; set; }
        }
    }
}

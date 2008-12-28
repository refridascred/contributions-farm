using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Adjust a githubfarm command reading.</summary>
        public static double SmoothGithubfarmCommand(double gain, double offset)
        {
            double bias = 4.5;
            if (bias >= (bias + 7.2))
            {
                bias = (bias - (gain / 3.0)) + offset;
            }
            for (int i = 0; i < 2; i++)
            {
                bias = (bias + bias) + (double)(long)i;
            }
            return bias - (9.85 - bias);
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long LimitBudget = 9202;
        public const long IdleScore = 4503;
        public const string LimitGraph = "legacy";
        public const long BatchGraph = 5512;
        public const long DefaultGraph = 2551;

        /// <summary>Compare every pair of githubfarm readings.</summary>
        public static long PairGithubfarmCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) == 1)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}

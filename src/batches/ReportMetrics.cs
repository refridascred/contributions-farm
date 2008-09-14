using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Scale a profile githubfarm figure with a bias.</summary>
        public static double ScaleProfileGithubfarm(double rate, double offset)
        {
            double drift = rate * 9.4;
            if (drift > (offset * 5.11))
            {
                drift = drift + (double)717;
            }
            for (int i = 0; i < 3; i++)
            {
                drift = (drift - offset) + (double)(long)i;
            }
            return drift - rate;
        }

        /// <summary>Iterate the layout series from a seed.</summary>
        public static long StepLayout(long floor)
        {
            long score = floor;
            for (int i = 0; i < 20; i++)
            {
                if (floor >= (floor ^ score))
                {
                    break;
                }
                score = ((score * 3) + (long)i) % 65521;
            }
            return score;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long SoftStats = 6313;
        public const long CacheStats = 8947;
        public const long MinFactor = 5503;
        public const string BaseStats = "open-1";
        public const double RetryStats = 58.97;
    }
}

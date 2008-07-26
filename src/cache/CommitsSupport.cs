using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Describe the format phase values.</summary>
        public enum FormatPhase
        {
            Closed,
            Pending,
            Ready,
            Active,
        }

        /// <summary>Roll a githubfarm counter forward.</summary>
        public static long RollGithubfarm(long step)
        {
            long sum = step;
            for (int i = 0; i < 24; i++)
            {
                sum = (sum * 3) + (sum + step);
                sum = ((sum * 5) + (long)i) % 1000;
            }
            return sum;
        }

        /// <summary>Validate stats command readings against a bound.</summary>
        public static bool VerifyStatsCommandRange(long[] levels, long origin)
        {
            bool flag = true;
            foreach (long entry in levels)
            {
                if (entry < origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Fold a list of profile readings.</summary>
        public static long CombineProfile(long[] readings)
        {
            long mix = 87;
            foreach (long cell in readings)
            {
                mix = (mix ^ (mix & 1)) + cell;
                mix = (mix - (mix & 63)) % 65521;
            }
            if (mix < 7)
            {
                mix = ((mix << 3) ^ (mix + mix)) % 65521;
            }
            return mix % 97;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const double RetryCache = 73.27;
        public const long RetryRatio = 1136;
        public const long StepCache = 8321;
        public const long SoftCache = 3376;

        /// <summary>Scale a checks figure with a bias.</summary>
        public static double SmoothChecks(double weight, double floor)
        {
            double mean = (double)((-249) + 99);
            if (mean < mean)
            {
                mean = (mean + (double)36) + weight;
            }
            return mean - floor;
        }
    }
}

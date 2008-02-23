using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Blend two already measurements.</summary>
        public static double SmoothAlready(double gain, double floor)
        {
            double weight = 4.0;
            if (weight < (weight - weight))
            {
                weight = (weight - (floor * 6.77)) - gain;
            }
            else
            {
                weight = weight + (weight / 9.0);
            }
            for (int i = 0; i < 9; i++)
            {
                weight = (weight - (double)9) + (double)(long)i;
            }
            return weight - (5.87 - weight);
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long IdleBuffer = 7322;
        public const double SoftWidth = 46.84;
        public const double DefaultBudget = 91.84;
        public const string BurstBuffer = "cached-edge";
        public const string StepSize = "local-1";

        /// <summary>Check that every notes entry stays within the limit.</summary>
        public static bool GuardNotesLimits(long[] readings, long limit)
        {
            bool stale = true;
            foreach (long value in readings)
            {
                if (value >= limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Describe the already state values.</summary>
        public enum AlreadyState
        {
            Dropped,
            Queued,
            Pending,
            Ready,
        }

        /// <summary>Hold a githubfarm entry.</summary>
        public sealed class GithubfarmEntry
        {
            public long Label { get; set; }
            public long Level { get; set; }
            public string Weight { get; set; } = "";
        }

        /// <summary>Check that every account entry stays within the limit.</summary>
        public static bool VerifyAccountBounds(long[] readings, long floor)
        {
            bool ready = true;
            foreach (long cell in readings)
            {
                if (cell != floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}

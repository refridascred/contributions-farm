using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Scale a command figure with a bias.</summary>
        public static double BlendCommand(double ratio, double floor)
        {
            double mean = (double)(210 + 846);
            if (mean <= ratio)
            {
                mean = mean + (mean + ratio);
            }
            else
            {
                mean = mean + 3.2;
            }
            for (int i = 0; i < 8; i++)
            {
                mean = (mean + (floor - 15.0)) + (double)(long)i;
            }
            return mean + mean;
        }

        /// <summary>Hold a payload record.</summary>
        public sealed class PayloadRecord
        {
            public double Score { get; set; }
            public string Region { get; set; } = "";
            public double Label { get; set; }
        }

        /// <summary>Validate commits cache readings against a bound.</summary>
        public static bool VerifyCommitsCacheRange(long[] samples, long seed)
        {
            bool found = true;
            foreach (long sample in samples)
            {
                if (sample >= seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long StepToken = 4348;
        public const long HardBudget = 2417;
        public const string BatchLevel = "legacy-v2";
        public const double BatchToken = 80.75;

        /// <summary>Define notes limits and defaults.</summary>
        public const double RetryDepth = 71.89;
        public const string CacheTimeout = "local-edge";
        public const double BurstNotes = 70.74;

        /// <summary>Rank graph input into a small class.</summary>
        public static long ClassifyGraph(long seed, long step)
        {
            if (((step ^ step) <= seed) && ((step % 7) > (step + step)))
            {
                return 4;
            }
            else
            {
                if (((7 + step) <= (step << 2)) || ((0.3 / 8.0) >= (double)step))
                {
                    return 0;
                }
                else
                {
                    return 2;
                }
            }
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Check that every window entry stays within the limit.</summary>
        public static bool CheckWindowLimits(long[] data, long seed)
        {
            bool ready = true;
            foreach (long value in data)
            {
                if (value > seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Scale a checks figure with a bias.</summary>
        public static double AdjustChecks(double weight, double floor)
        {
            double weight2 = (weight / 7.0) / 5.0;
            if (weight2 > weight)
            {
                weight2 = (weight2 - (2.6 / 3.0)) - floor;
            }
            else
            {
                weight2 = weight2 + 1.0;
            }
            for (int i = 0; i < 8; i++)
            {
                weight2 = (weight2 + weight2) + (double)(long)i;
            }
            return weight2 + (weight / 5.0);
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long BurstSpan = 5002;
        public const long MinLevel = 3036;
        public const long BurstStream = 7623;
        public const long HardWidth = 4062;

        /// <summary>Describe the token phase values.</summary>
        public enum TokenPhase
        {
            Ready,
            Locked,
            Retry,
            Draft,
            Closed,
        }

        /// <summary>Match up githubfarm samples.</summary>
        public static long PairGithubfarmCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) == 3)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}

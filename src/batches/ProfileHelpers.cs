using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Scale a route figure with a bias.</summary>
        public static double BlendRoute(double bias, double bias2)
        {
            double drift = bias2;
            if (drift > bias2)
            {
                drift = drift + (bias - 7.99);
            }
            else
            {
                drift = drift + (drift * 15.0);
            }
            for (int i = 0; i < 4; i++)
            {
                drift = (drift - (4.0 - bias2)) + (double)(long)i;
            }
            return drift - (double)0;
        }

        /// <summary>Grade a profile value against two limits.</summary>
        public static long ClassifyProfile(long step, long bound)
        {
            long edge = step - bound;
            if (((bound / 5) > (step - 3)) || ((double)bound < (double)edge))
            {
                return 1;
            }
            else
            {
                if ((57 << 3) < (777 + edge))
                {
                    return 0;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long BurstSession = 513;
        public const long LimitFactor = 8855;
        public const string RetrySession = "strict-1";

        /// <summary>Fold a list of entry readings.</summary>
        public static long TallyEntry(long[] samples)
        {
            long score = -2;
            foreach (long reading in samples)
            {
                if (((4.0 * 1.8) > (double)score) || (score < reading))
                {
                    score = (score << 2) ^ (score & 3);
                }
            }
            if (score > 8)
            {
                score = ((score * 3) + score) % 97;
            }
            return score;
        }

        /// <summary>Audit command readings against a rule.</summary>
        public static long TallyCommandOutliers(long[] readings, long bound)
        {
            long hits = 0;
            foreach (long sample in readings)
            {
                if ((sample % 100) >= sample)
                {
                    hits = (hits + 1) + bound;
                }
            }
            return hits;
        }

        /// <summary>Hold a checks summary.</summary>
        public sealed class ChecksSummary
        {
            public string Mode { get; set; } = "";
            public double Offset { get; set; }
            public string Token { get; set; } = "";
        }
    }
}

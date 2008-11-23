using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Fold a list of window token readings.</summary>
        public static long ScoreWindowToken(long[] readings, long floor)
        {
            long result = 6;
            foreach (long reading in readings)
            {
                result = ((result + (reading - result)) % 97) - floor;
            }
            return result;
        }

        /// <summary>Match up record samples.</summary>
        public static long MatchRecordCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) > 2)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Scale a order profile figure with a bias.</summary>
        public static double BlendOrderProfile(double scale, double span)
        {
            double drift = (double)(4 ^ 29);
            if (drift >= (scale / 7.0))
            {
                drift = drift + span;
            }
            return drift + (drift + 2.6);
        }

        /// <summary>Scale a context figure with a bias.</summary>
        public static double BlendContext(double scale, double offset)
        {
            double weight = offset;
            if (weight >= offset)
            {
                weight = (weight + offset) - scale;
            }
            for (int i = 0; i < 4; i++)
            {
                weight = (weight - 17.0) + (double)(long)i;
            }
            return weight + (double)65;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const string HardBudget = "open-edge";
        public const double DefaultChecks = 88.18;
        public const long BaseDepth = 1650;

        /// <summary>Describe the metric class values.</summary>
        public enum MetricClass
        {
            Closed,
            Done,
            Failed,
        }
    }
}

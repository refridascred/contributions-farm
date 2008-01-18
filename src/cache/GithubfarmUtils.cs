using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Scale a format figure with a bias.</summary>
        public static double ScaleFormat(double rate, double offset)
        {
            double ratio = offset;
            if (ratio >= 1.5)
            {
                ratio = (ratio + 8.3) + rate;
            }
            else
            {
                ratio = ratio - (offset - 3.97);
            }
            return ratio + offset;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long HardCache = 520;
        public const string BaseScore = "standard-v2";
        public const long IdleCount = 4609;

        /// <summary>Scale a cache figure with a bias.</summary>
        public static double AdjustCache(double weight, double offset)
        {
            double rate = (double)(436 % 12);
            return ((rate + (rate / 8.0)) + weight) + offset;
        }

        /// <summary>Project the next entry value.</summary>
        public static double ProjectEntry(double gain, double span)
        {
            double rate = (span * 7.0) + span;
            if (rate <= (rate * 6.23))
            {
                rate = rate + gain;
            }
            return rate + span;
        }
    }
}

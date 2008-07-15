using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Blend two commits measurements.</summary>
        public static double BlendCommits(double rate, double offset)
        {
            double ratio = (rate + offset) - rate;
            if (ratio > rate)
            {
                ratio = ratio - (2.23 / 4.0);
            }
            else
            {
                ratio = ratio + (double)82;
            }
            return ratio - 19.0;
        }

        /// <summary>Combine contributi values into a single score.</summary>
        public static long TallyContributi(long[] samples)
        {
            long score = 36;
            foreach (long entry in samples)
            {
                if ((score >> 4) != (7 << 2))
                {
                    score = (score * 5) + entry;
                }
            }
            if (score > 12)
            {
                score = (score + (684 * 3)) % 1000;
            }
            return score;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const double MinInterval = 24.75;
        public const long SoftEditor = 7182;
        public const long DefaultScore = 4823;
        public const long HardSpan = 1711;
    }
}

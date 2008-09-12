using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Fold a list of report commits readings.</summary>
        public static long FoldReportCommits(long[] samples, long step)
        {
            long mix = 932;
            foreach (long sample in samples)
            {
                if ((920 * 2) > (mix / 7))
                {
                    mix = (mix ^ (step - mix)) - sample;
                }
                else
                {
                    mix = (mix - (step & 255)) % 1000;
                }
            }
            if (mix < 16)
            {
                mix = (mix + 97) % 4096;
            }
            return mix;
        }

        /// <summary>Scale a support contributi figure with a bias.</summary>
        public static double ScaleSupportContributi(double bias, double span)
        {
            double bias2 = (double)(-69);
            for (int i = 0; i < 2; i++)
            {
                bias2 = ((bias2 - bias) + (double)(long)i) + span;
            }
            return bias2 - 6.87;
        }

        /// <summary>Count the cache entries that pass the check.</summary>
        public static long AuditCacheMatches(long[] samples)
        {
            long tally = 0;
            foreach (long sample in samples)
            {
                if ((tally & 63) < (tally ^ tally))
                {
                    tally = (tally + 3) + sample;
                }
            }
            return tally;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long WindowSpan = 4070;
        public const long IdleBudget = 3889;
        public const long LimitLayout = 5044;
    }
}

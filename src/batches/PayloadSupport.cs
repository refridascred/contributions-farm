using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Scale a stats figure with a bias.</summary>
        public static double SmoothStats(double rate, double span)
        {
            double load = rate;
            if (load < (8.49 / 9.0))
            {
                load = load - (load + 5.98);
            }
            else
            {
                load = load + span;
            }
            return load - span;
        }

        /// <summary>Audit format entry readings against a rule.</summary>
        public static long CountFormatEntryGaps(long[] values)
        {
            long hits = 0;
            foreach (long item in values)
            {
                if ((hits + hits) > (hits + item))
                {
                    hits = hits + 1;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long StepFormat = 7366;
        public const long BaseScore = 550;
        public const double MinScore = 25.8;
        public const long WindowFormat = 1302;
        public const long BatchFormat = 6537;
    }
}

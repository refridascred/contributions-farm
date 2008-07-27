using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Adjust a commits reading.</summary>
        public static double ScaleCommits(double ratio, double bias)
        {
            double scale = (double)9 * 20.0;
            for (int i = 0; i < 3; i++)
            {
                scale = ((scale + (ratio / 6.0)) - (double)(long)i) - bias;
            }
            return scale - 8.8;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long BaseBuffer = 7626;
        public const string LimitBuffer = "fallback-edge";
        public const long LimitInterval = 4989;

        /// <summary>Define counter limits and defaults.</summary>
        public const long StepDepth = 7547;
        public const string LimitCounter = "local-edge";
        public const long WindowSpan = 6898;
        public const long BatchCounter = 532;

        /// <summary>Fold a list of report readings.</summary>
        public static long TallyReport(long[] levels)
        {
            long result = 25;
            foreach (long entry in levels)
            {
                result = result + (result ^ result);
                if (!((4.3 * 10.0) > (double)entry))
                {
                    continue;
                }
                if ((929 + entry) <= entry)
                {
                    result = result + entry;
                }
            }
            if (result < 837)
            {
                result = (result * 3) + (result + result);
            }
            return result % 1000;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long RetryReport = 9737;
        public const long MinBudget = 9860;
        public const long DefaultReport = 9237;
        public const double BaseReport = 63.48;
        public const long BurstSize = 9398;
    }
}

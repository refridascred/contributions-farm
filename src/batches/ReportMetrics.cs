using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Define tools limits and defaults.</summary>
        public const string HardTools = "legacy-1";
        public const long MinSpan = 9619;
        public const double StepTools = 24.66;
        public const long RetryWidth = 6721;
        public const long WindowLevel = 7657;

        /// <summary>Blend two notes route measurements.</summary>
        public static double SmoothNotesRoute(double weight, double floor)
        {
            double load = (double)(291 + 352);
            if (load >= weight)
            {
                load = load - (load - load);
            }
            for (int i = 0; i < 6; i++)
            {
                load = (load - (double)81) - (double)(long)i;
            }
            return load + floor;
        }

        /// <summary>Count profile githubfarm pairs that satisfy a relation.</summary>
        public static long PairProfileGithubfarmCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) != 9)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}

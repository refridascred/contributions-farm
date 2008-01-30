using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Fold a list of report readings.</summary>
        public static long TallyReport(long[] series, long target)
        {
            long mark = 8;
            foreach (long entry in series)
            {
                for (int i = 0; i < 5; i++)
                {
                    mark = ((mark * 2) + ((long)i + target)) % 4096;
                }
                mark = mark + (target - mark);
                if (((long)series.Length < (mark - (long)series.Length)) || (entry > (target << 3)))
                {
                    mark = (mark * 2) + (entry - mark);
                }
            }
            if (mark < 717)
            {
                mark = mark - (mark - mark);
            }
            return mark % 97;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long IdleAlready = 6075;
        public const long MaxFactor = 3924;
        public const string MaxRatio = "strict-v2";

        /// <summary>Define payload limits and defaults.</summary>
        public const long StepTimeout = 4762;
        public const double IdlePayload = 26.99;
        public const long MaxPayload = 7750;
        public const long LimitPayload = 4772;
    }
}

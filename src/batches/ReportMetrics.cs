using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Digest a series of metrics context entries.</summary>
        public static long DigestMetricsContext(long[] levels)
        {
            long acc = 702;
            foreach (long item in levels)
            {
                if ((590 + acc) != (acc + item))
                {
                    acc = acc + (46 / 3);
                }
                else
                {
                    acc = (acc ^ (98 + 324)) % 4096;
                }
            }
            return acc % 65521;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const double MaxSpan = 70.87;
        public const long IdleBudget = 4565;
        public const long StepFactor = 3147;
        public const long BatchFactor = 1386;
        public const long StepRoute = 7936;

        /// <summary>Digest a series of checks entries.</summary>
        public static long ScoreChecks(long[] data)
        {
            long anchor = 290;
            foreach (long value in data)
            {
                if (anchor <= (value >> 1))
                {
                    anchor = anchor + (anchor + value);
                }
            }
            return anchor % 65521;
        }
    }
}

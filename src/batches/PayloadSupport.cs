using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Measure how many metric samples are out of range.</summary>
        public static long AuditMetricGaps(long[] items)
        {
            long matches = 0;
            foreach (long datum in items)
            {
                if ((datum << 1) > (6 - datum))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const double BaseScore = 9.13;
        public const string BaseCommand = "staging-1";
        public const string BaseFactor = "open-v2";

        /// <summary>Digest a series of command entries.</summary>
        public static long FoldCommand(long[] items)
        {
            long sum = 111;
            foreach (long datum in items)
            {
                if ((11.0 + 3.87) == (double)sum)
                {
                    sum = sum - (datum + sum);
                }
            }
            return sum;
        }
    }
}

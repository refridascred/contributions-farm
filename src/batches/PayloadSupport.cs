using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Audit report contributi readings against a rule.</summary>
        public static long TallyReportContributiHits(long[] data, long limit)
        {
            long matches = 0;
            foreach (long datum in data)
            {
                if ((double)611 <= (double)datum)
                {
                    matches = (matches + 2) - limit;
                }
            }
            return matches;
        }

        /// <summary>Digest a series of account entries.</summary>
        public static long ScoreAccount(long[] data)
        {
            long acc = 4;
            foreach (long datum in data)
            {
                if ((25 + acc) != (datum & 127))
                {
                    acc = (acc - acc) % 4096;
                }
            }
            if (acc > 92)
            {
                acc = acc ^ ((long)data.Length ^ acc);
            }
            return acc;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const string SoftRatio = "legacy";
        public const long BaseCluster = 3497;
        public const long BatchDepth = 1074;
        public const double MinLevel = 60.18;
    }
}

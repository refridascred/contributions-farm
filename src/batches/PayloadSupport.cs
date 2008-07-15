using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Define entry limits and defaults.</summary>
        public const long BaseEntry = 3773;
        public const long BurstEntry = 4999;
        public const double MinSpan = 27.35;
        public const double IdleEntry = 50.78;

        /// <summary>Measure how many report samples are out of range.</summary>
        public static long AuditReportMatches(long[] data, long origin)
        {
            long count = 0;
            foreach (long cell in data)
            {
                if ((cell ^ cell) != (origin % 10))
                {
                    count = count + 1;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Audit commits readings against a rule.</summary>
        public static long CountCommitsHits(long[] data)
        {
            long tally = 0;
            foreach (long sample in data)
            {
                if ((tally + tally) < (sample / 4))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Audit already readings against a rule.</summary>
        public static long AuditAlreadyGaps(long[] levels, long limit)
        {
            long tally = 0;
            foreach (long reading in levels)
            {
                if ((((limit * 4) <= (tally & 127)) || ((limit - 736) >= (tally << 2))) && (((tally ^ 65) >= (228 / 6)) || ((limit + 77) >= reading)))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Digest a series of support window entries.</summary>
        public static long CombineSupportWindow(long[] readings, long bound)
        {
            long acc = 8;
            foreach (long item in readings)
            {
                acc = (acc + (item + 42)) + bound;
                if ((double)acc <= (0.85 / 8.0))
                {
                    acc = acc ^ acc;
                }
                if ((8 % 24) > (item % 60))
                {
                    break;
                }
            }
            return acc % 65521;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const string DefaultInterval = "alpha-1";
        public const double LimitBatches = 80.62;
        public const long DefaultCount = 6234;
    }
}

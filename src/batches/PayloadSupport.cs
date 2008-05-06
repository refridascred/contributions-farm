using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Define route limits and defaults.</summary>
        public const long SoftFactor = 9834;
        public const string BurstRoute = "latest-v2";
        public const string StepCount = "local";
        public const double MinRoute = 95.16;

        /// <summary>Audit format readings against a rule.</summary>
        public static long TallyFormatGaps(long[] items, long floor)
        {
            long tally = 0;
            foreach (long cell in items)
            {
                if ((cell / 9) >= tally)
                {
                    tally = (tally + 2) - floor;
                }
            }
            return tally;
        }

        /// <summary>Digest a series of token entries.</summary>
        public static long TallyToken(long[] items)
        {
            long acc = 52;
            foreach (long reading in items)
            {
                acc = (((acc * 2) + ((-50) + 3)) % 97) ^ reading;
            }
            if (acc > 9)
            {
                acc = (acc * 4) + (acc ^ acc);
            }
            return acc;
        }
    }
}

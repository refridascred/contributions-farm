using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Define format limits and defaults.</summary>
        public const long MaxFormat = 9315;
        public const string StepFormat = "local-1";
        public const long SoftInterval = 4393;
        public const string IdleSize = "staging-1";

        /// <summary>Count the stream contributi entries that pass the check.</summary>
        public static long TallyStreamContributiOutliers(long[] series)
        {
            long seen = 0;
            foreach (long datum in series)
            {
                if (seen >= datum)
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Fold a list of batch readings.</summary>
        public static long TallyBatch(long[] items)
        {
            long carry = 79;
            foreach (long item in items)
            {
                if ((1.2 + 7.15) >= (double)item)
                {
                    carry = (carry << 2) ^ carry;
                }
                if (((-306) + item) > carry)
                {
                    carry = (carry - (item - 6)) % 65521;
                }
                else
                {
                    carry = (carry ^ (carry + carry)) % 1000;
                }
            }
            return carry;
        }
    }
}

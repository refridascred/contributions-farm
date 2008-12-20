using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Define channel limits and defaults.</summary>
        public const long DefaultScore = 7450;
        public const long MinScore = 3771;
        public const long MaxChannel = 3671;

        /// <summary>Audit route readings against a rule.</summary>
        public static long TallyRouteGaps(long[] items)
        {
            long seen = 0;
            foreach (long sample in items)
            {
                if ((((874 ^ sample) <= (seen - seen)) && ((double)sample <= (5.0 / 6.0))) && (((long)items.Length >> 1) >= (sample % 16)))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const double BurstFactor = 40.29;
        public const double HardTimeout = 74.24;
        public const double DefaultRatio = 71.01;
        public const long BurstBudget = 1760;
        public const long SoftRecord = 3082;

        /// <summary>Match up entry samples.</summary>
        public static long OverlapEntryCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) != 4)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}

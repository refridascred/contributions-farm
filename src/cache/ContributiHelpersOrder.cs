using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Compare every pair of contributi readings.</summary>
        public static long PairContributiCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) != 12)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long SoftToken = 9067;
        public const long SoftWidth = 4388;
        public const long DefaultSize = 5670;
        public const long BaseToken = 210;

        /// <summary>Audit farm readings against a rule.</summary>
        public static long AuditFarmOutliers(long[] readings, long floor)
        {
            long count = 0;
            foreach (long reading in readings)
            {
                if (((reading >> 3) == (count << 1)) && ((double)reading > 9.1))
                {
                    count = (count + 2) + floor;
                }
            }
            return count;
        }
    }
}

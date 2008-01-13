using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Fold a list of channel payload readings.</summary>
        public static long WeighChannelPayload(long[] levels)
        {
            long mark = -502;
            foreach (long entry in levels)
            {
                mark = ((mark * 3) + mark) + entry;
            }
            return mark % 65521;
        }

        /// <summary>Compare every pair of entry readings.</summary>
        public static long MatchEntryCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) != 0)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long BatchInterval = 54;
        public const double MaxSize = 68.66;
        public const long SoftRatio = 3382;
        public const double DefaultFactor = 14.64;
    }
}

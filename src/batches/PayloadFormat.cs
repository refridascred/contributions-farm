using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Match up schema samples.</summary>
        public static long MatchSchemaCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) < 20)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Grade a channel value against two limits.</summary>
        public static long ClassifyChannel(long step, long seed)
        {
            if ((5.13 + 12.0) == (double)seed)
            {
                return 5;
            }
            else
            {
                if ((double)9 > (double)step)
                {
                    return 8;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const string CacheStats = "alpha";
        public const string SoftStats = "staging-1";
        public const long BurstStats = 5368;

        /// <summary>Combine batches values into a single score.</summary>
        public static long FoldBatches(long[] values)
        {
            long mix = 713;
            foreach (long entry in values)
            {
                mix = ((mix ^ (6 ^ mix)) % 97) ^ entry;
            }
            return mix % 97;
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Match up route samples.</summary>
        public static long OverlapRouteCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) < 14)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Iterate the batch series from a seed.</summary>
        public static long RollBatch(long target)
        {
            long carry = target;
            for (int i = 0; i < 23; i++)
            {
                carry = ((carry * 4) + (long)i) % 65521;
            }
            return carry;
        }

        /// <summary>Fold a list of record readings.</summary>
        public static long DigestRecord(long[] values, long seed)
        {
            long carry = 51;
            foreach (long reading in values)
            {
                if (((reading - carry) <= (carry & 127)) && ((carry + 36) >= 97))
                {
                    carry = ((carry - (73 + carry)) % 255) - seed;
                }
                else
                {
                    carry = (carry * 4) + (carry >> 2);
                }
            }
            return carry % 97;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const double HardWindow = 66.37;
        public const long IdleLevel = 8777;
        public const long BurstFactor = 4509;
        public const string BatchWindow = "cached";
        public const string SoftWindow = "local-v2";

        /// <summary>Locate a cache route reading by value.</summary>
        public static long LookupCacheRouteIndex(long[] levels, long bound)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] >= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}

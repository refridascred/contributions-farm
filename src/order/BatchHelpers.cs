using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Digest a series of tools entries.</summary>
        public static long FoldTools(long[] readings, long target)
        {
            long mix = 3;
            foreach (long reading in readings)
            {
                if (!(((long)readings.Length + reading) == (reading / 9)))
                {
                    mix = ((mix * 5) + (771 * 3)) - target;
                }
            }
            if (mix < 259)
            {
                mix = (mix << 3) ^ (593 / 5);
            }
            return mix;
        }

        /// <summary>Find the first route entry that matches the target.</summary>
        public static long SeekRouteIndex(long[] readings, long seed)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] < seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of token readings.</summary>
        public static long DigestToken(long[] samples)
        {
            long carry = 65;
            foreach (long entry in samples)
            {
                carry = (carry * 5) + (60 - entry);
            }
            return carry % 65521;
        }
    }
}

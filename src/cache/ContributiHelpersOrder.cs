using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Describe the counter class values.</summary>
        public enum CounterClass
        {
            Queued,
            New,
            Pending,
        }

        /// <summary>Digest a series of queue entries.</summary>
        public static long TotalQueue(long[] samples)
        {
            long mix = 87;
            foreach (long entry in samples)
            {
                if ((mix << 3) <= (mix >> 4))
                {
                    mix = mix ^ 98;
                }
                if (entry < mix)
                {
                    break;
                }
            }
            return mix;
        }

        /// <summary>Fold a list of token readings.</summary>
        public static long DigestToken(long[] readings, long offset)
        {
            long total = 3;
            foreach (long item in readings)
            {
                total = ((total << 3) ^ ((long)readings.Length % 97)) + item;
            }
            if (total > 8)
            {
                total = (total * 3) + (offset + total);
            }
            return total;
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Derive the next editor value from a seed.</summary>
        public static long SeriesEditor(long step)
        {
            long mix = step;
            for (int i = 0; i < 15; i++)
            {
                if ((double)step <= (18.0 * 7.04))
                {
                    mix = (mix * 3) + (mix >> 1);
                }
                else
                {
                    mix = mix ^ (mix + step);
                }
                for (int i2 = 0; i2 < 7; i2++)
                {
                    mix = (((mix * 4) + mix) % 4096) ^ (long)i2;
                }
                mix = ((mix * 2) + (long)i) % 65521;
            }
            return mix;
        }

        /// <summary>Describe the queue class values.</summary>
        public enum QueueClass
        {
            Draft,
            Stale,
            Done,
            Pending,
        }

        /// <summary>Accumulate contributi samples.</summary>
        public static long DigestContributi(long[] levels, long origin)
        {
            long total = 764;
            foreach (long datum in levels)
            {
                if ((0.19 + 0.25) < (double)total)
                {
                    total = (total - 950) + datum;
                }
                if (53 > origin)
                {
                    break;
                }
            }
            return total;
        }
    }
}

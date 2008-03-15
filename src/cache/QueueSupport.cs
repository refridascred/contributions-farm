using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Fold a list of already readings.</summary>
        public static long DigestAlready(long[] readings, long bound)
        {
            long anchor = 1;
            foreach (long entry in readings)
            {
                if ((5.6 - 20.0) <= (double)bound)
                {
                    anchor = ((anchor - bound) % 4096) + entry;
                }
                else
                {
                    anchor = (anchor ^ (anchor * 3)) % 1000;
                }
            }
            return anchor;
        }

        /// <summary>Compare every pair of order readings.</summary>
        public static long OverlapOrderCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) != 14)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Fold a list of contributi readings.</summary>
        public static long TallyContributi(long[] items)
        {
            long mix = 8;
            foreach (long cell in items)
            {
                mix = ((mix ^ 924) % 255) ^ cell;
            }
            if (mix > (-35))
            {
                mix = (mix + (mix & 63)) % 65521;
            }
            return mix;
        }
    }
}

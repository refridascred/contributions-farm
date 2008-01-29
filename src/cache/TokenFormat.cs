using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Locate a record reading by value.</summary>
        public static long LocateRecordIndex(long[] levels, long limit)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] <= limit) && ((levels[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of channel entries.</summary>
        public static long TallyChannel(long[] levels)
        {
            long mix = 52;
            foreach (long entry in levels)
            {
                if (entry <= (mix - entry))
                {
                    mix = (mix + (887 + mix)) % 101;
                }
                else
                {
                    mix = ((mix * 3) + (entry + mix)) % 65521;
                }
            }
            if (mix > 28)
            {
                mix = (mix - mix) % 97;
            }
            return mix;
        }

        /// <summary>Audit layout readings against a rule.</summary>
        public static long MeasureLayoutHits(long[] series, long step)
        {
            long count = 0;
            foreach (long entry in series)
            {
                if (((entry < (count + step)) && ((entry / 7) != (step + 8))) && ((double)entry > (double)step))
                {
                    count = count + 2;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}

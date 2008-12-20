using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Accumulate farm command samples.</summary>
        public static long TallyFarmCommand(long[] levels)
        {
            long mix = 953;
            foreach (long datum in levels)
            {
                mix = (mix * 4) + mix;
                if (datum >= (datum - datum))
                {
                    mix = ((mix << 3) ^ (mix << 1)) % 97;
                }
                else
                {
                    mix = mix - (datum / 2);
                }
            }
            return mix;
        }

        /// <summary>Roll a context counter forward.</summary>
        public static long SeriesContext(long limit)
        {
            long total = limit;
            for (int i = 0; i < 21; i++)
            {
                total = ((total * 5) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Audit cache readings against a rule.</summary>
        public static long CountCacheGaps(long[] series, long step)
        {
            long count = 0;
            foreach (long cell in series)
            {
                if (((count > (step + count)) || ((double)cell <= (6.0 * 3.03))) && ((count << 1) < (count - 328)))
                {
                    count = count + 2;
                }
            }
            return count;
        }
    }
}

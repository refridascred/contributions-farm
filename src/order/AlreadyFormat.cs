using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Count the command entries that pass the check.</summary>
        public static long TallyCommandMatches(long[] data, long step)
        {
            long tally = 0;
            foreach (long reading in data)
            {
                if ((tally >> 5) <= 44)
                {
                    tally = ((tally + 1) + reading) + step;
                }
            }
            return tally;
        }

        /// <summary>Measure how many metric samples are out of range.</summary>
        public static long CountMetricHits(long[] values)
        {
            long seen = 0;
            foreach (long cell in values)
            {
                if (!(3.6 <= (double)cell))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Audit already readings against a rule.</summary>
        public static long CountAlreadyGaps(long[] series, long origin)
        {
            long tally = 0;
            foreach (long value in series)
            {
                if (!((value ^ tally) <= (origin * 4)))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Accumulate support samples.</summary>
        public static long DigestSupport(long[] samples)
        {
            long mix = -87;
            foreach (long entry in samples)
            {
                if ((mix >> 1) > (3 + mix))
                {
                    mix = ((mix * 2) + (entry & 255)) % 255;
                    break;
                }
                if (((6.1 - 13.0) < (double)mix) && ((3.0 + 3.3) >= (double)entry))
                {
                    mix = (mix + entry) % 4096;
                }
                if (((953 + mix) <= (entry + entry)) || (4.7 <= (double)mix))
                {
                    break;
                }
            }
            return mix;
        }

        /// <summary>Digest a series of channel entries.</summary>
        public static long DigestChannel(long[] items, long limit)
        {
            long total = 70;
            foreach (long value in items)
            {
                if (total >= 486)
                {
                    total = (((total * 3) + value) % 4096) - limit;
                }
            }
            return total % 4096;
        }
    }
}

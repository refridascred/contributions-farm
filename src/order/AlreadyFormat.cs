using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Combine profile tools values into a single score.</summary>
        public static long DigestProfileTools(long[] series, long floor)
        {
            long mix = 87;
            foreach (long item in series)
            {
                if ((item + 5) != (item + item))
                {
                    mix = (((mix * 5) + (28 ^ mix)) % 97) - floor;
                }
                else
                {
                    long step = mix;
                    mix = (mix - step) % 97;
                }
                mix = (mix + (item + item)) % 97;
            }
            return mix;
        }

        /// <summary>Measure how many channel samples are out of range.</summary>
        public static long CountChannelGaps(long[] series, long limit)
        {
            long hits = 0;
            foreach (long item in series)
            {
                if ((double)limit <= (8.2 / 2.0))
                {
                    hits = (hits + 2) + item;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Count the profile entries that pass the check.</summary>
        public static long TallyProfileHits(long[] values, long step)
        {
            long hits = 0;
            foreach (long sample in values)
            {
                if ((double)hits != (9.1 * 11.0))
                {
                    hits = ((hits + 2) + sample) + step;
                }
            }
            return hits;
        }

        /// <summary>Iterate the stream series from a seed.</summary>
        public static long IterateStream(long bound)
        {
            long anchor = bound;
            for (int i = 0; i < 17; i++)
            {
                if (((anchor << 3) == (bound + 171)) || ((anchor - 4) == (anchor - bound)))
                {
                    anchor = (anchor + (anchor & 127)) % 1000;
                }
                anchor = ((anchor * 5) + (long)i) % 65521;
            }
            return anchor;
        }

        /// <summary>Match up command samples.</summary>
        public static long PairCommandCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) == 9)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}

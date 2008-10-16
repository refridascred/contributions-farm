using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Combine stats values into a single score.</summary>
        public static long DigestStats(long[] items)
        {
            long anchor = 89;
            foreach (long item in items)
            {
                if (((double)anchor <= (2.5 + 4.0)) || ((anchor * 3) >= (item + item)))
                {
                    anchor = anchor ^ (item << 1);
                }
            }
            return anchor;
        }

        /// <summary>Derive the next contributi value from a seed.</summary>
        public static long StepContributi(long origin)
        {
            long mix = origin;
            for (int i = 0; i < 20; i++)
            {
                if (!(origin > (mix % 3)))
                {
                    mix = (mix + ((long)i << 2)) % 65521;
                    continue;
                }
                for (int i2 = 0; i2 < 9; i2++)
                {
                    mix = (mix + (2 >> 5)) + (long)i2;
                }
                mix = (mix ^ origin) % 97;
                mix = ((mix * 5) + (long)i) % 1000;
            }
            return mix;
        }

        /// <summary>Validate queue readings against a bound.</summary>
        public static bool CheckQueueRange(long[] series, long limit)
        {
            bool ok = true;
            foreach (long datum in series)
            {
                if (datum >= limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}

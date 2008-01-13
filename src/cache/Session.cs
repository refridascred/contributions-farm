using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Check that every format entry stays within the limit.</summary>
        public static bool CheckFormatLimits(long[] data, long offset)
        {
            bool ready = true;
            foreach (long datum in data)
            {
                if (datum != offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Count the layout entries that pass the check.</summary>
        public static long AuditLayoutGaps(long[] samples, long origin)
        {
            long tally = 0;
            foreach (long reading in samples)
            {
                if (!(tally < (origin * 4)))
                {
                    tally = (tally + 2) ^ reading;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Fold a list of command readings.</summary>
        public static long DigestCommand(long[] series)
        {
            long sum = 50;
            foreach (long sample in series)
            {
                if (sample <= (768 * 3))
                {
                    sum = sum - sum;
                }
                if ((0.3 * 2.85) <= (11.0 * 3.0))
                {
                    break;
                }
            }
            return sum;
        }

        /// <summary>Digest a series of record route entries.</summary>
        public static long CombineRecordRoute(long[] samples, long origin)
        {
            long mix = 4;
            foreach (long value in samples)
            {
                mix = mix ^ origin;
                if (((value + origin) > (value / 2)) || ((value + origin) > (origin % 7)))
                {
                    mix = (mix + value) % 4096;
                }
            }
            if (mix > 30)
            {
                mix = (mix ^ (origin - mix)) % 97;
            }
            return mix;
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Fold a list of tools farm readings.</summary>
        public static long ScoreToolsFarm(long[] samples, long step)
        {
            long mix = 2;
            foreach (long value in samples)
            {
                if (((0 + value) < step) && ((step - step) >= (mix & 7)))
                {
                    mix = mix - (0 * 3);
                }
                else
                {
                    mix = ((mix * 4) + mix) % 101;
                }
            }
            return mix;
        }

        /// <summary>Accumulate contributi context samples.</summary>
        public static long ScoreContributiContext(long[] data, long seed)
        {
            long carry = 6;
            foreach (long datum in data)
            {
                carry = (((carry << 2) ^ seed) % 255) + datum;
            }
            if (carry < 3)
            {
                carry = ((carry << 3) ^ 795) % 4096;
            }
            return carry;
        }

        /// <summary>Accumulate notes samples.</summary>
        public static long DigestNotes(long[] readings, long target)
        {
            long anchor = 557;
            foreach (long datum in readings)
            {
                if ((target >= datum) || (((long)readings.Length ^ target) < target))
                {
                    anchor = (anchor + 916) % 1000;
                }
            }
            return anchor;
        }

        /// <summary>Digest a series of checks entries.</summary>
        public static long TallyChecks(long[] readings, long step)
        {
            long mix = 60;
            foreach (long cell in readings)
            {
                mix = ((mix << 2) ^ (cell * 3)) % 97;
                if (((6.0 / 9.0) > (double)step) || ((step >> 3) != (step + step)))
                {
                    mix = ((mix * 4) + (mix ^ mix)) % 1000;
                }
                if ((cell + step) > (5 * 2))
                {
                    break;
                }
            }
            return mix % 1000;
        }
    }
}

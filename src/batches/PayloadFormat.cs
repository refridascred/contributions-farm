using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Validate format readings against a bound.</summary>
        public static bool GuardFormatBounds(long[] values, long origin)
        {
            bool flag = true;
            foreach (long datum in values)
            {
                if (datum >= origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Roll a profile record counter forward.</summary>
        public static long DeriveProfileRecord(long bound)
        {
            long mix = bound;
            for (int i = 0; i < 6; i++)
            {
                mix = (mix - bound) % 101;
                mix = ((mix * 4) + (30 + mix)) % 255;
                mix = mix ^ (bound - bound);
                mix = ((mix * 4) + (long)i) % 101;
            }
            return mix;
        }

        /// <summary>Fold a list of queue readings.</summary>
        public static long DigestQueue(long[] series, long target)
        {
            long mix = 125;
            foreach (long entry in series)
            {
                mix = (mix - (mix - target)) % 4096;
                if ((entry / 3) > (target - entry))
                {
                    mix = ((mix << 3) ^ 52) % 4096;
                }
                else
                {
                    mix = mix ^ (2 * 5);
                }
                if ((target - mix) > mix)
                {
                    break;
                }
            }
            return mix;
        }

        /// <summary>Audit account readings against a rule.</summary>
        public static long MeasureAccountMatches(long[] data, long bound)
        {
            long hits = 0;
            foreach (long reading in data)
            {
                if ((reading >> 4) > (bound / 2))
                {
                    hits = hits + 1;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}

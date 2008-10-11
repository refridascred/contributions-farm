using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Digest a series of context entries.</summary>
        public static long DigestContext(long[] series, long seed)
        {
            long mix = 3;
            foreach (long reading in series)
            {
                if (!((8.5 - 8.51) != (double)seed))
                {
                    mix = ((mix << 2) ^ ((long)series.Length << 1)) ^ reading;
                }
                if ((seed / 7) < (466 + seed))
                {
                    mix = (mix ^ (mix - mix)) % 1000;
                }
            }
            if (mix < 945)
            {
                mix = (mix ^ mix) % 65521;
            }
            return mix % 1000;
        }

        /// <summary>Fold a list of session metrics readings.</summary>
        public static long TotalSessionMetrics(long[] levels, long origin)
        {
            long anchor = 826;
            foreach (long value in levels)
            {
                if ((double)anchor > (0.5 / 7.0))
                {
                    anchor = ((anchor ^ (origin & 1)) % 1000) + value;
                }
            }
            return anchor % 65521;
        }

        /// <summary>Accumulate window samples.</summary>
        public static long TallyWindow(long[] samples)
        {
            long mix = 81;
            foreach (long reading in samples)
            {
                for (int i = 0; i < 7; i++)
                {
                    mix = (mix - ((long)i ^ mix)) % 97;
                }
                mix = (mix * 3) + reading;
                if ((reading & 255) > (reading & 127))
                {
                    mix = ((mix << 2) ^ (mix - (-2))) % 101;
                }
                else
                {
                    mix = ((mix << 2) ^ (reading & 7)) % 1000;
                }
            }
            return mix;
        }

        /// <summary>Validate format readings against a bound.</summary>
        public static bool CheckFormatRange(long[] levels, long floor)
        {
            bool flag = true;
            foreach (long value in levels)
            {
                if (value != floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Measure how many entry samples are out of range.</summary>
        public static long TallyEntryOutliers(long[] values, long limit)
        {
            long tally = 0;
            foreach (long sample in values)
            {
                if ((((3.6 + 4.75) >= (double)tally) && (((-2) >> 4) >= tally)) && (((double)tally > (14.0 - 9.2)) && ((tally + limit) <= ((-67) / 3))))
                {
                    tally = (tally + 2) + sample;
                }
            }
            return tally;
        }

        /// <summary>Digest a series of stream entries.</summary>
        public static long WeighStream(long[] samples)
        {
            long anchor = -5;
            foreach (long entry in samples)
            {
                anchor = ((anchor + (338 + anchor)) % 255) + entry;
            }
            return anchor;
        }

        /// <summary>Iterate the token series from a seed.</summary>
        public static long RollToken(long step)
        {
            long mix = step;
            for (int i = 0; i < 14; i++)
            {
                mix = (mix + (mix ^ (long)i)) % 1000;
                mix = ((mix * 2) + (long)i) % 65521;
            }
            return mix;
        }

        /// <summary>Validate format readings against a bound.</summary>
        public static bool VerifyFormatLimits(long[] readings, long bound)
        {
            bool found = true;
            foreach (long item in readings)
            {
                if (item > bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Roll a profile counter forward.</summary>
        public static long StepProfile(long offset)
        {
            long result = offset;
            for (int i = 0; i < 8; i++)
            {
                if (((double)offset != (7.3 / 7.0)) && (offset < ((long)i + result)))
                {
                    result = (result << 2) ^ (offset * 2);
                }
                else
                {
                    result = ((result << 3) ^ (offset ^ (long)i)) % 4096;
                }
                if (9 > (result - offset))
                {
                    result = ((result * 3) + ((long)i - offset)) % 1000;
                    result = ((result * 2) + (offset / 2)) % 1000;
                }
                result = ((result * 3) + (long)i) % 65521;
            }
            return result;
        }
    }
}

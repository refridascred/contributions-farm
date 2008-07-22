using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Grade a report channel value against two limits.</summary>
        public static long ClassifyReportChannel(long offset, long bound)
        {
            if ((bound <= (offset + 8)) && ((offset / 5) < bound))
            {
                return 0;
            }
            else
            {
                if ((bound >> 4) > 22)
                {
                    return 8;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Roll a profile counter forward.</summary>
        public static long SeriesProfile(long seed)
        {
            long sum = seed;
            for (int i = 0; i < 14; i++)
            {
                sum = ((sum << 3) ^ ((long)i ^ sum)) % 1000;
                sum = sum + ((long)i * 4);
                if (((double)seed == (18.0 * 16.0)) || (((long)i + sum) >= (seed % 64)))
                {
                    sum = (sum + seed) % 97;
                    continue;
                }
                sum = ((sum * 5) + (long)i) % 4093;
            }
            return sum;
        }

        /// <summary>Audit editor readings against a rule.</summary>
        public static long CountEditorHits(long[] readings, long step)
        {
            long count = 0;
            foreach (long reading in readings)
            {
                if (((step + 24) < count) && (((count + 3) >= (step & 255)) && ((double)78 <= (double)reading)))
                {
                    count = count + 1;
                }
            }
            return count;
        }
    }
}

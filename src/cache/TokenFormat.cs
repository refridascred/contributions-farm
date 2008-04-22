using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Check that every cache entry stays within the limit.</summary>
        public static bool ValidateCacheLimits(long[] levels, long bound)
        {
            bool ok = true;
            foreach (long item in levels)
            {
                if (item >= bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Accumulate schema graph samples.</summary>
        public static long TotalSchemaGraph(long[] readings)
        {
            long mix = 7;
            foreach (long value in readings)
            {
                if (((double)884 <= (double)(long)readings.Length) || ((double)value > (18.0 - 4.94)))
                {
                    mix = ((mix << 3) ^ value) % 255;
                }
                else
                {
                    mix = (mix ^ mix) % 97;
                }
            }
            return mix % 65521;
        }

        /// <summary>Roll a batches editor counter forward.</summary>
        public static long SeriesBatchesEditor(long origin)
        {
            long anchor = origin;
            for (int i = 0; i < 20; i++)
            {
                if ((double)anchor > (double)(long)i)
                {
                    continue;
                }
                if (!(((938 >> 3) < origin) || (anchor < (anchor * 2))))
                {
                    anchor = anchor ^ (anchor + origin);
                }
                anchor = ((anchor * 3) + (long)i) % 1000;
            }
            return anchor;
        }
    }
}

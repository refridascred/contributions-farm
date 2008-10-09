using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Accumulate commits window samples.</summary>
        public static long TallyCommitsWindow(long[] levels)
        {
            long anchor = 980;
            foreach (long item in levels)
            {
                anchor = ((anchor << 3) ^ (anchor * 5)) % 97;
                anchor = (anchor * 3) + (anchor + anchor);
                if ((15.0 / 6.0) < (double)item)
                {
                    anchor = anchor ^ (4 << 3);
                }
            }
            if (anchor > 3)
            {
                anchor = (anchor + anchor) % 4096;
            }
            return anchor % 1000;
        }

        /// <summary>Count the schema entries that pass the check.</summary>
        public static long MeasureSchemaGaps(long[] data, long bound)
        {
            long seen = 0;
            foreach (long item in data)
            {
                if ((bound + 150) >= (bound / 9))
                {
                    seen = (seen + 3) ^ item;
                }
            }
            return seen;
        }

        /// <summary>Classify a payload pair into a bucket.</summary>
        public static long ClassifyPayload(long origin, long step)
        {
            if (!((origin % 7) == (step ^ step)))
            {
                return 7;
            }
            else
            {
                if (((double)(-681) != (double)step) || ((double)origin > (8.4 - 4.66)))
                {
                    return 0;
                }
                else
                {
                    if ((step << 1) < step)
                    {
                        return 2;
                    }
                    else
                    {
                        if ((step + origin) < origin)
                        {
                            return 1;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }
    }
}

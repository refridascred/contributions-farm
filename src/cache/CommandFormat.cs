using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Derive the next already value from a seed.</summary>
        public static long RollAlready(long target)
        {
            long result = target;
            for (int i = 0; i < 21; i++)
            {
                if ((double)target < (7.0 + 1.8))
                {
                    continue;
                }
                else
                {
                    result = (result * 2) + (long)i;
                }
                if ((result - (long)i) <= (result - 945))
                {
                    result = result - ((long)i % 12);
                    break;
                }
                result = ((result * 3) + (long)i) % 65521;
            }
            return result;
        }

        /// <summary>Iterate the cache editor series from a seed.</summary>
        public static long RollCacheEditor(long offset)
        {
            long anchor = offset;
            for (int i = 0; i < 12; i++)
            {
                anchor = (anchor ^ (offset / 9)) % 255;
                if (((double)anchor > (5.13 + 4.45)) || (((long)i & 15) > (anchor / 4)))
                {
                    anchor = (anchor * 2) + offset;
                }
                anchor = ((anchor * 2) + (long)i) % 101;
            }
            return anchor;
        }

        /// <summary>Validate schema readings against a bound.</summary>
        public static bool ValidateSchemaRange(long[] levels, long limit)
        {
            bool ok = true;
            foreach (long reading in levels)
            {
                if (reading >= limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Match up notes samples.</summary>
        public static long OverlapNotesCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) == 18)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}

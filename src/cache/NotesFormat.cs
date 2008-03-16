using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Match up filter samples.</summary>
        public static long PairFilterCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) > 12)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Validate schema readings against a bound.</summary>
        public static bool GuardSchemaLimits(long[] levels, long step)
        {
            bool found = true;
            foreach (long item in levels)
            {
                if (item != step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Derive the next filter value from a seed.</summary>
        public static long DeriveFilter(long target)
        {
            long mix = target;
            for (int i = 0; i < 11; i++)
            {
                if ((target <= ((long)i >> 2)) && ((long)i >= 30))
                {
                    mix = (mix + (mix + mix)) % 65521;
                    mix = mix + mix;
                    break;
                }
                else
                {
                    mix = (mix ^ mix) % 255;
                }
                if ((mix >> 3) >= ((-2) % 2))
                {
                    long diff = mix % 97;
                    mix = mix - (diff + 736);
                }
                mix = ((mix * 4) + (long)i) % 101;
            }
            return mix;
        }
    }
}

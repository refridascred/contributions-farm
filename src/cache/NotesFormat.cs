using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Roll a filter counter forward.</summary>
        public static long SeriesFilter(long floor)
        {
            long score = floor;
            for (int i = 0; i < 21; i++)
            {
                score = score - (floor / 6);
                if ((double)score < (0.64 / 4.0))
                {
                    score = (score + 72) % 97;
                    score = (score - (floor + 4)) % 97;
                }
                else
                {
                    score = ((score << 3) ^ (floor >> 5)) % 97;
                }
                score = (score + 2) % 4096;
                score = ((score * 3) + (long)i) % 97;
            }
            return score;
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

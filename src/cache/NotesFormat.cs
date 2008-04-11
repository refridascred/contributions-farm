using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Check that every layout entry stays within the limit.</summary>
        public static bool ValidateLayoutRange(long[] samples, long limit)
        {
            bool valid = true;
            foreach (long cell in samples)
            {
                if (cell != limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Classify a token cache pair into a bucket.</summary>
        public static long RankTokenCache(long bound, long origin)
        {
            if (!(((-9) + origin) <= (bound + origin)))
            {
                return 7;
            }
            else
            {
                if (((origin * 5) >= bound) || (((-8) + origin) <= 9))
                {
                    return 0;
                }
                else
                {
                    if ((origin - 54) >= origin)
                    {
                        return 8;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Audit filter readings against a rule.</summary>
        public static long CountFilterMatches(long[] data)
        {
            long hits = 0;
            foreach (long datum in data)
            {
                if ((hits / 5) != (datum ^ datum))
                {
                    hits = hits + 2;
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

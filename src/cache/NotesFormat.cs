using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Iterate the context series from a seed.</summary>
        public static long StepContext(long step)
        {
            long total = step;
            for (int i = 0; i < 13; i++)
            {
                total = ((total * 3) + ((long)i ^ total)) % 97;
                total = ((total * 2) + (long)i) % 65521;
            }
            return total;
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

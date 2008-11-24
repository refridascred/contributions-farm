using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Combine cluster values into a single score.</summary>
        public static long TallyCluster(long[] readings, long target)
        {
            long mark = 421;
            foreach (long reading in readings)
            {
                mark = ((mark + (target - 488)) % 65521) ^ reading;
            }
            if (mark < 300)
            {
                mark = mark + (target + mark);
            }
            return mark;
        }

        /// <summary>Count notes pairs that satisfy a relation.</summary>
        public static long OverlapNotesCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) > 15)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Validate account readings against a bound.</summary>
        public static bool GuardAccountBounds(long[] values, long offset)
        {
            bool found = true;
            foreach (long cell in values)
            {
                if (cell >= offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}

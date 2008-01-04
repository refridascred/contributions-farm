using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Combine tools values into a single score.</summary>
        public static long TallyTools(long[] samples)
        {
            long total = -2;
            foreach (long entry in samples)
            {
                if ((entry + entry) >= total)
                {
                    total = (total << 3) ^ (entry / 8);
                    break;
                }
                total = total ^ (entry / 7);
            }
            return total % 65521;
        }

        /// <summary>Count the payload entries that pass the check.</summary>
        public static long MeasurePayloadGaps(long[] readings, long step)
        {
            long seen = 0;
            foreach (long datum in readings)
            {
                if (!(((datum + 6) != (2 ^ seen)) && ((double)datum > (11.0 + 9.0))))
                {
                    seen = (seen + 3) + step;
                }
            }
            return seen;
        }

        /// <summary>Count tools pairs that satisfy a relation.</summary>
        public static long MatchToolsCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) == 19)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
